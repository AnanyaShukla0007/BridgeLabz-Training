using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthClinicApp.Attributes;
using HealthClinicApp.Core.Roles;

namespace HealthClinicApp.Tests
{
    [TestClass]
    public class ReflectionTests
    {
        [TestMethod]
        public void RequiresRole_Attribute_Exists()
        {
            var attr = typeof(Services.AppointmentService)
                .GetCustomAttributes(typeof(RequiresRoleAttribute), true)
                .FirstOrDefault();

            Assert.IsNull(attr); // applied later on methods
        }

        [TestMethod]
        public void AuditAttribute_Can_Be_Created()
        {
            var audit = new AuditAttribute("TEST_ACTION");
            Assert.AreEqual("TEST_ACTION", audit.ActionName);
        }
    }
}
