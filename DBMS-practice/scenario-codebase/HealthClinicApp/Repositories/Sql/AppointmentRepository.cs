using Microsoft.Data.SqlClient;
using System.Data;
using HealthClinicApp.DataAccess;

namespace HealthClinicApp.Repositories.Sql
{
    public class AppointmentRepository
    {
        public int BookAppointment(
            int patientId,
            int doctorId,
            DateTime date,
            TimeSpan time)
        {
            using var conn = DbConnectionFactory.CreateConnection();
            using var cmd = new SqlCommand("sp_BookAppointment", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@PatientId", SqlDbType.Int).Value = patientId;
            cmd.Parameters.Add("@DoctorId", SqlDbType.Int).Value = doctorId;
            cmd.Parameters.Add("@Date", SqlDbType.Date).Value = date.Date;
            cmd.Parameters.Add("@Time", SqlDbType.Time).Value = time;

            var appointmentIdParam =
                new SqlParameter("@AppointmentId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

            cmd.Parameters.Add(appointmentIdParam);

            conn.Open();
            cmd.ExecuteNonQuery();

            return (int)appointmentIdParam.Value;
        }
    }
}
