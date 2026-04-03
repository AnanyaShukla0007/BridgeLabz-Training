using System;
using HealthClinicApp.Core.Exceptions;

namespace HealthClinicApp.Utilities.Validators
{
    /// <summary>
    /// Validates appointment date and time.
    /// </summary>
    public static class AppointmentValidator
    {
        public static void ValidateAppointmentDateTime(
            DateTime appointmentDate,
            TimeSpan appointmentTime)
        {
            var appointmentDateTime =
                appointmentDate.Date + appointmentTime;

            if (appointmentDateTime <= DateTime.Now)
            {
                throw new ValidationException(
                    "Appointment date and time must be after the current date and time."
                );
            }
        }
    }
}
