using System;
using System.Linq;
using HealthClinicApp.Menus;
using HealthClinicApp.Services;
using HealthClinicApp.Core.Session;
using HealthClinicApp.Core.Roles;
using HealthClinicApp.Core.Exceptions;
using HealthClinicApp.Models.Patient;
using HealthClinicApp.Models.Appointment;
using HealthClinicApp.Utilities;
using HealthClinicApp.Utilities.Validators;

namespace HealthClinicApp
{
    internal class Program
    {
        private static readonly ClinicSession Session = new();

        private static readonly PatientService PatientService = new();
        private static readonly AppointmentService AppointmentService = new();
        private static readonly VisitService VisitService = new();
        private static readonly BillingService BillingService = new();
        private static readonly PaymentService PaymentService = new();

        private const string ReceptionistPassword = "admin007";

        static void Main()
        {
            while (true)
            {
                try
                {
                    MainMenu.Show();
                    var choice = Console.ReadLine();

                    switch (choice)
                    {
                        case "1":
                            RunPatientFlow();
                            break;
                        case "2":
                            RunReceptionistFlow();
                            break;
                        case "3":
                            return;
                        default:
                            Console.WriteLine("Invalid choice.");
                            break;
                    }
                }
                catch (ClinicException ex)
                {
                    Console.WriteLine($"ERROR: {ex.Message}");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"UNEXPECTED ERROR: {ex.Message}");
                }
            }
        }

        /* =========================
           PATIENT FLOW
           ========================= */

        private static void RunPatientFlow()
        {
            Session.Reset();
            PatientMenu.ShowWelcome();

            Console.Write("Enter Patient Name: ");
            var name = Console.ReadLine()!;

            Console.Write("Enter Date of Birth (dd-MM-yyyy): ");
            var dob = DateTimeHelper.ParseDate(Console.ReadLine()!);

            PatientValidator.ValidateBasicIdentity(name, dob);

            var patient =
                PatientService.FindExistingPatient(name, dob)
                ?? RegisterNewPatient(name, dob);

            Session.RegisterPatient(patient);
            PrintPatientSlip(patient);

            PatientMenu.AskAppointmentDecision();
            if (Console.ReadLine() != "1") return;

            PatientMenu.ShowSpecialtyOptions();
            var choice = Console.ReadLine();

            var (specialtyId, specialtyName) = choice switch
            {
                "1" => (1, "General Medicine"),
                "2" => (2, "Cardiology"),
                "3" => (3, "Dermatology"),
                "4" => (4, "Orthopedics"),
                _ => throw new ValidationException("Invalid specialty.")
            };

            Console.Write("Enter preferred appointment date (dd-MM-yyyy): ");
            var date = DateTimeHelper.ParseDate(Console.ReadLine()!);

            Console.Write("Enter preferred appointment time (HH:mm): ");
            var time = DateTimeHelper.ParseTime(Console.ReadLine()!);

            AppointmentValidator.ValidateAppointmentDateTime(date, time);

            var request = PatientService.CreateAppointmentRequest(
                patient.PatientId,
                specialtyId,
                specialtyName,
                date,
                time
            );

            AppointmentService.AddPending(request);
            Session.RequestAppointment(request);

            PrintAppointmentRequestSlip(patient, request);
        }

        private static PatientModel RegisterNewPatient(string name, DateTime dob)
        {
            Console.Write("Enter Phone Number: ");
            var phone = Console.ReadLine()!;

            Console.Write("Enter Email: ");
            var email = Console.ReadLine()!;

            Console.Write("Enter Address: ");
            var address = Console.ReadLine()!;

            Console.Write("Enter Pincode: ");
            var pincode = Console.ReadLine()!;

            Console.Write("Enter Blood Group: ");
            var bloodGroup = Console.ReadLine()!;

            PatientValidator.ValidateFullDetails(phone, email, bloodGroup);

            return PatientService.RegisterNewPatient(new PatientModel
            {
                Name = name,
                DateOfBirth = dob,
                Phone = phone,
                Email = email,
                Address = address,
                Pincode = pincode,
                BloodGroup = bloodGroup
            });
        }

        /* =========================
           RECEPTIONIST FLOW
           ========================= */

        private static void RunReceptionistFlow()
        {
            ReceptionistMenu.ShowLogin();
            if (Console.ReadLine() != ReceptionistPassword)
                throw new AuthorizationException("Invalid receptionist password.");

            while (true)
            {
                ReceptionistMenu.ShowDashboard();
                var choice = Console.ReadLine();

                if (choice == "3") return;
                if (choice == "1") ShowPendingAppointments();
                if (choice == "2")
                {
                    bool backToPatientPortal = ProcessAppointment();
                    if (backToPatientPortal) return;
                }
            }
        }

        private static void ShowPendingAppointments()
        {
            var pending = AppointmentService.GetPendingAppointments();

            if (!pending.Any())
            {
                Console.WriteLine("No pending appointments.");
                return;
            }

            foreach (var p in pending)
            {
                Console.WriteLine("----------------------------------------");
                Console.WriteLine($"Patient ID : {p.PatientId}");
                Console.WriteLine($"Specialty  : {p.SpecialtyName}");
                Console.WriteLine($"Date       : {DateTimeHelper.FormatDate(p.PreferredDate)}");
                Console.WriteLine($"Time       : {DateTimeHelper.FormatTime(p.PreferredTime)}");
                Console.WriteLine($"Status     : {p.Status}");
            }
        }

        private static bool ProcessAppointment()
        {
            ReceptionistMenu.AskPatientId();
            var pid = int.Parse(Console.ReadLine()!);

            var request = AppointmentService.GetPendingAppointments()
                .FirstOrDefault(r => r.PatientId == pid);

            if (request == null)
            {
                Console.WriteLine("No pending request found.");
                return false;
            }

            var doctors = AppointmentService.GetAvailableDoctors(
                request.SpecialtyId,
                request.PreferredDate,
                request.PreferredTime
            );

            if (!doctors.Any())
            {
                Console.WriteLine("No doctor available. Appointment cancelled.");
                AppointmentService.CancelAppointment(request);
                return false;
            }

            var doctor = doctors.First();
            var confirmed = AppointmentService.ConfirmAppointment(request, doctor);
            Session.ConfirmAppointment(confirmed);

            PrintAppointmentConfirmedSlip(Session.CurrentPatient!, confirmed);

            ReceptionistMenu.AskVisitCompletion();
            if (Console.ReadLine() != "1") return false;

            var diagnoses = VisitService.GetDiagnosesBySpecialty(request.SpecialtyId);
            for (int i = 0; i < diagnoses.Count; i++)
                Console.WriteLine($"{i + 1}. {diagnoses[i].DiagnosisName}");

            var diagnosis = diagnoses[int.Parse(Console.ReadLine()!) - 1];

            var visitId = VisitService.CompleteVisit(
                confirmed.AppointmentId,
                diagnosis.DiagnosisId
            );

            Session.CompleteVisit();

            var medicine = VisitService.GetMedicineByDiagnosis(diagnosis.DiagnosisId);

            Console.WriteLine("\nDiagnosis recorded ✔");
            Console.WriteLine($"Medicine Name : {medicine.MedicineName}");
            Console.WriteLine($"Dosage        : {medicine.Dosage}");
            Console.WriteLine($"Duration      : {medicine.Duration}");
            Console.WriteLine($"Medicine Fee  : ₹{medicine.MedicineFee}");

            var bill = BillingService.GenerateBill(visitId);
            Session.GenerateBill(bill);

            PrintBillSlip(confirmed.ConsultationFee, medicine.MedicineFee);

            ReceptionistMenu.AskPaymentMode();
            var mode = Console.ReadLine() switch
            {
                "1" => "Cash",
                "2" => "UPI",
                "3" => "Card",
                _ => throw new ValidationException("Invalid payment mode.")
            };

            PaymentService.RecordPayment(bill.BillId, mode);
            Session.RecordPayment();

            PrintPaymentSlip(
                bill.BillId,
                mode,
                confirmed.ConsultationFee + medicine.MedicineFee
            );

            Console.WriteLine("Thank you for visiting!");
            Console.WriteLine("Do you want to process the next patient?");
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");

            if (Console.ReadLine() == "1")
            {
                // Session.Reset();
                return true; // 🔁 BACK TO PATIENT PORTAL
            }

            Environment.Exit(0);
            return false;
        }

        /* =========================
           SLIPS
           ========================= */

        private static void PrintPatientSlip(PatientModel p)
        {
            ConsolePrinter.PrintSeparator();
            Console.WriteLine("PATIENT REGISTRATION SUCCESSFUL");
            ConsolePrinter.PrintSeparator();
            ConsolePrinter.PrintLine("Patient ID", p.PatientId.ToString("D3"));
            ConsolePrinter.PrintLine("Name", p.Name);
            ConsolePrinter.PrintLine("DOB", DateTimeHelper.FormatDate(p.DateOfBirth));
            ConsolePrinter.PrintLine("Phone", p.Phone);
            ConsolePrinter.PrintLine("Email", p.Email);
            ConsolePrinter.PrintLine("Address",p.Address);
            ConsolePrinter.PrintLine("Blood Group",p.BloodGroup);
            ConsolePrinter.PrintLine("Registered At", p.RegisteredAt.ToString("dd-MM-yyyy HH:mm"));
            
            ConsolePrinter.PrintSeparator();
        }

        private static void PrintAppointmentRequestSlip(
            PatientModel p, AppointmentRequestModel r)
        {
            ConsolePrinter.PrintSeparator();
            Console.WriteLine("APPOINTMENT REQUEST SUBMITTED");
            ConsolePrinter.PrintSeparator();
            ConsolePrinter.PrintLine("Patient ID", p.PatientId.ToString("D3"));
            ConsolePrinter.PrintLine("Specialty", r.SpecialtyName);
            ConsolePrinter.PrintLine("Date", DateTimeHelper.FormatDate(r.PreferredDate));
            ConsolePrinter.PrintLine("Time", DateTimeHelper.FormatTime(r.PreferredTime));
            ConsolePrinter.PrintLine("Status", r.Status);
            
            ConsolePrinter.PrintSeparator();
        }

        private static void PrintAppointmentConfirmedSlip(
            PatientModel p, AppointmentModel a)
        {
            ConsolePrinter.PrintSeparator();
            Console.WriteLine("APPOINTMENT CONFIRMED");
            ConsolePrinter.PrintSeparator();
            ConsolePrinter.PrintLine("Patient ID", p.PatientId.ToString("D3"));
            ConsolePrinter.PrintLine("Doctor", a.DoctorName);
            ConsolePrinter.PrintLine("Specialty", a.SpecialtyName);
            ConsolePrinter.PrintLine("Date", DateTimeHelper.FormatDate(a.AppointmentDate));
            ConsolePrinter.PrintLine("Time", DateTimeHelper.FormatTime(a.AppointmentTime));
            ConsolePrinter.PrintLine("Fee", $"₹{a.ConsultationFee}");
            ConsolePrinter.PrintSeparator();
        }

        private static void PrintBillSlip(int consultFee, int medicineFee)
        {
            ConsolePrinter.PrintSeparator();
            Console.WriteLine("BILL SUMMARY");
            ConsolePrinter.PrintLine("Consultation Fee", $"₹{consultFee}");
            ConsolePrinter.PrintLine("Medicine Fee", $"₹{medicineFee}");
            ConsolePrinter.PrintLine("TOTAL", $"₹{consultFee + medicineFee}");
            ConsolePrinter.PrintSeparator();
        }

        private static void PrintPaymentSlip(int billId, string mode, int amount)
        {
            ConsolePrinter.PrintSeparator();
            Console.WriteLine("PAYMENT SUCCESSFUL");
            ConsolePrinter.PrintLine("Bill ID", billId.ToString("D3"));
            ConsolePrinter.PrintLine("Payment Mode", mode);
            ConsolePrinter.PrintLine("Payment Date", DateTime.Now.ToString("dd-MM-yyyy HH:mm"));
            ConsolePrinter.PrintLine("Amount Paid", $"₹{amount}");
            ConsolePrinter.PrintSeparator();
        }
    }
}
