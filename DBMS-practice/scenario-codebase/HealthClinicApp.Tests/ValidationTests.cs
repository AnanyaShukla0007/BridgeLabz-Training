using System;
using HealthClinicApp.Interfaces;
using HealthClinicApp.Models.Billing;
using HealthClinicApp.Repositories.Sql;

namespace HealthClinicApp.Services
{
    public class PaymentService : IPaymentService
    {
        private readonly PaymentRepository _paymentRepo = new();

        public PaymentModel RecordPayment(int billId, string paymentMode)
        {
            _paymentRepo.RecordPayment(billId, paymentMode);

            return new PaymentModel
            {
                BillId = billId,
                PaymentMode = paymentMode,
                PaymentDate = DateTime.Now
            };
        }
    }
}
