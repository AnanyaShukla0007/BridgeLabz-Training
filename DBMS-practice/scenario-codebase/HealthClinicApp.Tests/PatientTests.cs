using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthClinicApp.Services;
using HealthClinicApp.Models.Patient;

namespace HealthClinicApp.Tests
{
    [TestClass]
    public class PatientTests
    {
        [TestMethod]
        public void Patient_Registration_Assigns_Id()
        {
            var service = new PatientService();

            var patient = service.RegisterNewPatient(new PatientModel
            {
                Name = "Test User",
                DateOfBirth = new DateTime(2000, 1, 1),
                Phone = "9998887776",
                Email = "test@mail.com",
                Address = "Agra",
                Pincode = "282001",
                BloodGroup = "A+"
            });

            Assert.IsTrue(patient.PatientId > 0);
        }
    }
}
