using Microsoft.Data.SqlClient;
using System.Data;
using HealthClinicApp.DataAccess;

namespace HealthClinicApp.Repositories.Sql
{
    public class VisitRepository
    {
        public int RecordVisit(int appointmentId, int diagnosisId)
        {
            using var conn = DbConnectionFactory.CreateConnection();
            using var cmd = new SqlCommand("sp_RecordVisit", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@AppointmentId", SqlDbType.Int).Value = appointmentId;
            cmd.Parameters.Add("@DiagnosisId", SqlDbType.Int).Value = diagnosisId;

            var visitIdParam =
                new SqlParameter("@VisitId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.Output
                };

            cmd.Parameters.Add(visitIdParam);

            conn.Open();
            cmd.ExecuteNonQuery();

            return (int)visitIdParam.Value;
        }
    }
}
