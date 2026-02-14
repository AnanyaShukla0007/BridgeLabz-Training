using HealthClinicApp.Models.Diagnosis;
using HealthClinicApp.Models.Medicine;

namespace HealthClinicApp.Interfaces
{
    /// <summary>
    /// Handles visit completion and diagnosis.
    /// </summary>
    public interface IVisitService
    {
        /// <summary>
        /// Returns diagnoses for a specialty.
        /// </summary>
        System.Collections.Generic.List<DiagnosisModel>
            GetDiagnosesBySpecialty(int specialtyId);

        /// <summary>
        /// Gets medicine mapped to a diagnosis.
        /// </summary>
        MedicineModel GetMedicineByDiagnosis(int diagnosisId);

        /// <summary>
        /// Records visit completion.
        /// </summary>
        int CompleteVisit(int appointmentId, int diagnosisId);
    }
}
