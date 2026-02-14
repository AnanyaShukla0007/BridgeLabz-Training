using System;
using HealthClinicApp.Models.Patient;
using HealthClinicApp.Models.Appointment;

namespace HealthClinicApp.Interfaces
{
    /// <summary>
    /// Handles patient self-service operations.
    /// </summary>
    public interface IPatientService
    {
        /// <summary>
        /// Finds an existing patient by Name + DOB.
        /// Returns null if not found.
        /// </summary>
        PatientModel FindExistingPatient(string name, DateTime dob);

        /// <summary>
        /// Registers a new patient and persists to JSON.
        /// </summary>
        PatientModel RegisterNewPatient(PatientModel patient);

        /// <summary>
        /// Creates an appointment request for the patient.
        /// </summary>
        AppointmentRequestModel CreateAppointmentRequest(
            int patientId,
            int specialtyId,
            string specialtyName,
            DateTime preferredDate,
            TimeSpan preferredTime
        );
    }
}
