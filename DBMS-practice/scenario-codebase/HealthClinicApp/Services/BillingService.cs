using HealthClinicApp.Interfaces;
using HealthClinicApp.Models.Billing;
using HealthClinicApp.Repositories.Sql;

namespace HealthClinicApp.Services
{
    public class BillingService : IBillingService
    {
        private readonly BillRepository _billRepo = new();

        public BillModel GenerateBill(int visitId)
        {
            int billId = _billRepo.GenerateBill(visitId);

            return new BillModel
            {
                BillId = billId,
                VisitId = visitId,
                PaymentStatus = "UNPAID"
            };
        }
    }
}
