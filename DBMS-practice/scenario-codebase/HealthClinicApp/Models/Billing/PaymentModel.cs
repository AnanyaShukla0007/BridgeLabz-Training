using System;

namespace HealthClinicApp.Models.Billing
{
    /// <summary>
    /// Payment transaction stored in SQL.
    /// Mirrors payment_transactions table.
    /// </summary>
    public class PaymentModel
    {
        public int TransactionId { get; set; }

        public int BillId { get; set; }

        public string PaymentMode { get; set; }

        public DateTime PaymentDate { get; set; }
    }
}
