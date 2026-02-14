using System;

namespace HealthClinicApp.Models.Billing
{
    /// <summary>
    /// Bill generated after visit completion.
    /// Mirrors bills table.
    /// </summary>
    public class BillModel
    {
        public int BillId { get; set; }

        public int VisitId { get; set; }

        public int ConsultationFee { get; set; }

        public int MedicineFee { get; set; }

        public int TotalAmount { get; set; }

        public string PaymentStatus { get; set; }

        public DateTime GeneratedAt { get; set; }
    }
}
