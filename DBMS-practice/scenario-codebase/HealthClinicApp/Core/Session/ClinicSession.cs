using HealthClinicApp.Core.Exceptions;
using HealthClinicApp.Models.Patient;
using HealthClinicApp.Models.Appointment;
using HealthClinicApp.Models.Billing;

namespace HealthClinicApp.Core.Session
{
    public class ClinicSession
    {
        public PatientModel? CurrentPatient { get; private set; }
        public AppointmentRequestModel? AppointmentRequest { get; private set; }
        public AppointmentModel? ConfirmedAppointment { get; private set; }
        public int VisitNumber { get; private set; }
        public BillModel? CurrentBill { get; private set; }

        public PatientState State { get; private set; } = PatientState.NEW;

        private readonly VisitTracker _visitTracker = new();

        public void RegisterPatient(PatientModel patient)
        {
            Enforce(PatientState.NEW);
            CurrentPatient = patient;
            VisitNumber = _visitTracker.GetNextVisitNumber(patient.PatientId);
            State = PatientState.REGISTERED;
        }

        public void RequestAppointment(AppointmentRequestModel request)
        {
            Enforce(PatientState.REGISTERED);
            AppointmentRequest = request;
            State = PatientState.APPOINTMENT_REQUESTED;
        }

        public void ConfirmAppointment(AppointmentModel appointment)
        {
            Enforce(PatientState.APPOINTMENT_REQUESTED);
            ConfirmedAppointment = appointment;
            State = PatientState.APPOINTMENT_CONFIRMED;
        }

        public void CompleteVisit()
        {
            Enforce(PatientState.APPOINTMENT_CONFIRMED);
            State = PatientState.VISIT_COMPLETED;
        }

        public void GenerateBill(BillModel bill)
        {
            Enforce(PatientState.VISIT_COMPLETED);
            CurrentBill = bill;
            State = PatientState.BILLED;
        }

        public void RecordPayment()
        {
            Enforce(PatientState.BILLED);
            State = PatientState.PAID;
        }

        public void Reset()
        {
            CurrentPatient = null;
            AppointmentRequest = null;
            ConfirmedAppointment = null;
            CurrentBill = null;
            VisitNumber = 0;
            State = PatientState.NEW;
        }

        private void Enforce(PatientState expected)
        {
            if (State != expected)
                throw new ClinicException(
                    $"Invalid state transition. Expected {expected}, but current state is {State}."
                );
        }
    }

}
