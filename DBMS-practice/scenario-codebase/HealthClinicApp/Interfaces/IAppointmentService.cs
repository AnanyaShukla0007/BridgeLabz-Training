using System.Collections.Generic;
using HealthClinicApp.Models.Appointment;
using HealthClinicApp.Models.Doctor;

namespace HealthClinicApp.Interfaces
{
    /// <summary>
    /// Handles appointment processing by receptionist.
    /// </summary>
    public interface IAppointmentService
    {
        /// <summary>
        /// Returns all pending appointment requests.
        /// </summary>
        List<AppointmentRequestModel> GetPendingAppointments();

        /// <summary>
        /// Gets available doctors for a specialty and time slot.
        /// </summary>
        List<DoctorModel> GetAvailableDoctors(
            int specialtyId,
            System.DateTime date,
            System.TimeSpan time
        );

        /// <summary>
        /// Confirms appointment and assigns doctor.
        /// </summary>
        AppointmentModel ConfirmAppointment(
            AppointmentRequestModel request,
            DoctorModel doctor
        );

        /// <summary>
        /// Cancels a pending appointment request.
        /// </summary>
        void CancelAppointment(AppointmentRequestModel request);
    }
}
