using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthClinicApp.Core.Session;
using HealthClinicApp.Models.Patient;

namespace HealthClinicApp.Tests
{
    [TestClass]
    public class StateMachineTests
    {
        [TestMethod]
        public void New_To_Registered_Works()
        {
            var session = new ClinicSession();
            var patient = new PatientModel { PatientId = 1 };

            session.RegisterPatient(patient);

            Assert.AreEqual(PatientState.REGISTERED, session.State);
        }
    }
}
