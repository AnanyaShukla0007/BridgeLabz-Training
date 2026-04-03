using System;

namespace HealthClinicApp.Models.Patient
{
    /// <summary>
    /// Represents a single visit of a patient.
    /// Used only for history tracking (not billing).
    /// </summary>
    public class PatientVisit
    {
        public int VisitNumber { get; set; }

        public DateTime VisitDate { get; set; }

        public string Specialty { get; set; }

        public string DoctorName { get; set; }
    }
}
