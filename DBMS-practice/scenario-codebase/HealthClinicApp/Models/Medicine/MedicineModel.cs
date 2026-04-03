namespace HealthClinicApp.Models.Medicine
{
    /// <summary>
    /// Medicine auto-mapped from diagnosis.
    /// Mirrors medicines table.
    /// </summary>
    public class MedicineModel
    {
        public int MedicineId { get; set; }

        public string MedicineName { get; set; }

        public int DiagnosisId { get; set; }

        public string Dosage { get; set; }

        public string Duration { get; set; }

        public int MedicineFee { get; set; }
    }
}
