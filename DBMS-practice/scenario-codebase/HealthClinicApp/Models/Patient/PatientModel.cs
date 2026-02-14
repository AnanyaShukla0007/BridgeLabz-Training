using System;
using System.Collections.Generic;

namespace HealthClinicApp.Models.Patient
{
    /// <summary>
    /// Represents a patient stored in JSON.
    /// PatientId never changes across visits.
    /// </summary>
    public class PatientModel
    {
        public int PatientId { get; set; }

        public string Name { get; set; }

        // dd-MM-yyyy enforced by validator, not here
        public DateTime DateOfBirth { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Address { get; set; }

        public string Pincode { get; set; }

        public string BloodGroup { get; set; }

        public DateTime RegisteredAt { get; set; }

        // Visit history (Visit #1, #2, etc.)
        public List<PatientVisit> Visits { get; set; } = new();
    }
}
