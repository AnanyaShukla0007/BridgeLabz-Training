using System;
using System.Collections.Generic;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Models.Appointment;
using HealthClinicApp.Models.Doctor;
using HealthClinicApp.Repositories.Sql;

namespace HealthClinicApp.Services
{
    public class AppointmentService : IAppointmentService
    {
        private readonly DoctorRepository _doctorRepo = new();
        private readonly AppointmentRepository _appointmentRepo = new();

        private readonly List<AppointmentRequestModel> _pending =
            new();

        public List<AppointmentRequestModel> GetPendingAppointments()
        {
            return _pending;
        }

        public List<DoctorModel> GetAvailableDoctors(
            int specialtyId,
            DateTime date,
            TimeSpan time)
        {
            return _doctorRepo.GetAvailableDoctors(
                specialtyId,
                date,
                time
            );
        }

        public AppointmentModel ConfirmAppointment(
            AppointmentRequestModel request,
            DoctorModel doctor)
        {
            int appointmentId = _appointmentRepo.BookAppointment(
            request.PatientId,
            doctor.DoctorId,
            request.PreferredDate,
            request.PreferredTime
            );

            request.Status = "SCHEDULED";
            _pending.Remove(request);

            return new AppointmentModel
            {
                AppointmentId = appointmentId,   // 🔥 IMPORTANT
                PatientId = request.PatientId,
                DoctorId = doctor.DoctorId,
                DoctorName = doctor.FullName,
                SpecialtyName = request.SpecialtyName,
                AppointmentDate = request.PreferredDate,
                AppointmentTime = request.PreferredTime,
                ConsultationFee = doctor.ConsultationFee,
                Status = "SCHEDULED"
            };
        }


        public void CancelAppointment(AppointmentRequestModel request)
        {
            request.Status = "CANCELLED";
            _pending.Remove(request);
        }

        public void AddPending(AppointmentRequestModel request)
        {
            _pending.Add(request);
        }
    }
}
