using System.Data;
using Microsoft.Data.SqlClient;
using HealthClinicApp.DataAccess;

namespace HealthClinicApp.Repositories.Sql
{
    public class BillRepository
    {
        public int GenerateBill(int visitId)
        {
            using var conn = DbConnectionFactory.CreateConnection();
            using var cmd = new SqlCommand("sp_GenerateBill", conn);

            cmd.CommandType = CommandType.StoredProcedure;

            // INPUT
            cmd.Parameters.Add(
                new SqlParameter("@VisitId", SqlDbType.Int)
                {
                    Value = visitId
                }
            );

            // OUTPUT
            var billIdParam = new SqlParameter("@BillId", SqlDbType.Int)
            {
                Direction = ParameterDirection.Output
            };
            cmd.Parameters.Add(billIdParam);

            conn.Open();
            cmd.ExecuteNonQuery();

            return (int)billIdParam.Value;
        }
    }
}
