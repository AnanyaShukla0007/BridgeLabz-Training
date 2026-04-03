using HealthClinicApp.Models.Billing;

namespace HealthClinicApp.Interfaces
{
    /// <summary>
    /// Handles bill generation.
    /// </summary>
    public interface IBillingService
    {
        /// <summary>
        /// Generates bill for a visit.
        /// </summary>
        BillModel GenerateBill(int visitId);
    }
}
