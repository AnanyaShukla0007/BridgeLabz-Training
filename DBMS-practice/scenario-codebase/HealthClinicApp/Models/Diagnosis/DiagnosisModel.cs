namespace HealthClinicApp.Models.Diagnosis
{
    /// <summary>
    /// Diagnosis mapped to a specialty.
    /// Mirrors diagnoses table.
    /// </summary>
    public class DiagnosisModel
    {
        public int DiagnosisId { get; set; }

        public string DiagnosisName { get; set; }

        public int SpecialtyId { get; set; }
    }
}
