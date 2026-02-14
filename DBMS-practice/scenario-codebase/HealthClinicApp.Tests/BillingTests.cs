using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthClinicApp.Services;

namespace HealthClinicApp.Tests
{
    [TestClass]
    public class BillingTests
    {
        [TestMethod]
        public void Bill_Initial_Status_Is_Unpaid()
        {
            var billingService = new BillingService();

            var bill = billingService.GenerateBill(1);

            Assert.AreEqual("UNPAID", bill.PaymentStatus);
        }
    }
}
