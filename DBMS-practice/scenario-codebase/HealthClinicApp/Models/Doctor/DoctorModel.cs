namespace HealthClinicApp.Models.Doctor
{
    /// <summary>
    /// Represents a doctor record from SQL.
    /// </summary>
    public class DoctorModel
    {
        public int DoctorId { get; set; }

        public string FullName { get; set; }

        public string Contact { get; set; }

        public int ConsultationFee { get; set; }

        public int SpecialtyId { get; set; }

        public string SpecialtyName { get; set; }

        public bool IsActive { get; set; }
    }
}
