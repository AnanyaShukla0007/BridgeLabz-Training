using System.Collections.Generic;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Models.Diagnosis;
using HealthClinicApp.Models.Medicine;
using HealthClinicApp.Repositories.Sql;


namespace HealthClinicApp.Services
{
    public class VisitService : IVisitService
    {
        private readonly DiagnosisRepository _diagnosisRepo = new();
        private readonly MedicineRepository _medicineRepo = new();
        private readonly VisitRepository _visitRepo = new();

        public List<DiagnosisModel> GetDiagnosesBySpecialty(int specialtyId)
        {
            return _diagnosisRepo.GetBySpecialty(specialtyId);
        }

        public MedicineModel GetMedicineByDiagnosis(int diagnosisId)
        {
            return _medicineRepo.GetByDiagnosis(diagnosisId);
        }

        public int CompleteVisit(int appointmentId, int diagnosisId)
        {
            return _visitRepo.RecordVisit(appointmentId, diagnosisId);
        }

    }
}
