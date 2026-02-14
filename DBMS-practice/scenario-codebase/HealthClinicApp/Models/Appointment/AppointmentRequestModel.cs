using System;

namespace HealthClinicApp.Models.Appointment
{
    /// <summary>
    /// Appointment request created by patient.
    /// Stored temporarily until receptionist confirms.
    /// </summary>
    public class AppointmentRequestModel
    {
        public int PatientId { get; set; }

        public string PatientName { get; set; }

        public int SpecialtyId { get; set; }

        public string SpecialtyName { get; set; }

        public DateTime PreferredDate { get; set; }

        public TimeSpan PreferredTime { get; set; }

        // Always PENDING at creation
        public string Status { get; set; } = "PENDING";
    }
}
