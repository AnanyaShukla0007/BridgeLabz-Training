using System.Collections.Generic;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Models.Doctor;
using HealthClinicApp.Repositories.Sql;

namespace HealthClinicApp.Services
{
    public class DoctorService : IDoctorService
    {
        private readonly DoctorRepository _doctorRepository = new();

        public List<DoctorModel> GetAllDoctors()
        {
            // Not exposed via stored procedure yet
            // Placeholder for future extension
            return new List<DoctorModel>();
        }

        public List<DoctorModel> GetDoctorsBySpecialty(int specialtyId)
        {
            // Availability is checked via AppointmentService
            return new List<DoctorModel>();
        }
    }
}
