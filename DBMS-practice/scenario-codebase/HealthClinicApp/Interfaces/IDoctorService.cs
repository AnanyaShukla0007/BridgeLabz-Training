using System.Collections.Generic;
using HealthClinicApp.Models.Doctor;

namespace HealthClinicApp.Interfaces
{
    /// <summary>
    /// Handles doctor-related operations.
    /// </summary>
    public interface IDoctorService
    {
        /// <summary>
        /// Returns all active doctors.
        /// </summary>
        List<DoctorModel> GetAllDoctors();

        /// <summary>
        /// Returns doctors by specialty.
        /// </summary>
        List<DoctorModel> GetDoctorsBySpecialty(int specialtyId);
    }
}
