using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HealthClinicApp.Services;
using HealthClinicApp.Models.Appointment;

namespace HealthClinicApp.Tests
{
    [TestClass]
    public class AppointmentTests
    {
        [TestMethod]
        public void Appointment_Request_Is_Pending_By_Default()
        {
            var service = new PatientService();

            var request = service.CreateAppointmentRequest(
                1,
                1,
                "General Medicine",
                DateTime.Today.AddDays(1),
                new TimeSpan(10, 0, 0)
            );

            Assert.AreEqual("PENDING", request.Status);
        }
    }
}
