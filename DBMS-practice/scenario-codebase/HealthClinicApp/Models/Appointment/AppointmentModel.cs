using System;

namespace HealthClinicApp.Models.Appointment
{
    /// <summary>
    /// Confirmed appointment stored in SQL.
    /// Mirrors appointments table.
    /// </summary>
    public class AppointmentModel
    {
        public int AppointmentId { get; set; }

        public int PatientId { get; set; }

        public int DoctorId { get; set; }

        public string DoctorName { get; set; }

        public string SpecialtyName { get; set; }

        public DateTime AppointmentDate { get; set; }

        public TimeSpan AppointmentTime { get; set; }

        public int ConsultationFee { get; set; }

        public string Status { get; set; }
    }
}
