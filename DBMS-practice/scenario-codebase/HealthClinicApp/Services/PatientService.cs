using System;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Models.Patient;
using HealthClinicApp.Models.Appointment;
using HealthClinicApp.Repositories.Json;
using HealthClinicApp.Utilities.Validators;

namespace HealthClinicApp.Services
{
    public class PatientService : IPatientService
    {
        private readonly PatientJsonRepository _repo = new();

        public PatientModel FindExistingPatient(string name, DateTime dob)
        {
            PatientValidator.ValidateBasicIdentity(name, dob);
            return _repo.FindByNameAndDob(name, dob);
        }

        public PatientModel RegisterNewPatient(PatientModel patient)
        {
            // ✅ Validate only
            PatientValidator.ValidateBasicIdentity(
                patient.Name,
                patient.DateOfBirth
            );

            PatientValidator.ValidateFullDetails(
                patient.Phone,
                patient.Email,
                patient.BloodGroup
            );

            // ✅ ID + RegisteredAt handled INSIDE repository
            return _repo.Add(patient);
        }

        public AppointmentRequestModel CreateAppointmentRequest(
            int patientId,
            int specialtyId,
            string specialtyName,
            DateTime preferredDate,
            TimeSpan preferredTime)
        {
            AppointmentValidator.ValidateAppointmentDateTime(
                preferredDate,
                preferredTime
            );

            return new AppointmentRequestModel
            {
                PatientId = patientId,
                SpecialtyId = specialtyId,
                SpecialtyName = specialtyName,
                PreferredDate = preferredDate,
                PreferredTime = preferredTime
            };
        }
    }
}
