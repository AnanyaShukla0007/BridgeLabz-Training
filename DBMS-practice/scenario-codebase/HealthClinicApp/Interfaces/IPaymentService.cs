using HealthClinicApp.Models.Billing;

namespace HealthClinicApp.Interfaces
{
    /// <summary>
    /// Handles payment recording.
    /// </summary>
    public interface IPaymentService
    {
        /// <summary>
        /// Records payment and returns transaction details.
        /// </summary>
        PaymentModel RecordPayment(int billId, string paymentMode);
    }
}
