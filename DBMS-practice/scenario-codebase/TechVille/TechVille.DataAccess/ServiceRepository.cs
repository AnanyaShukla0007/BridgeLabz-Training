using System.Data;
using Microsoft.Data.SqlClient;


namespace TechVille.DataAccess
{
    public static class ServiceRepository
    {
        public static void InsertService(string name, string type, bool emergency)
        {
            using SqlConnection con = new SqlConnection(DBConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_InsertService", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ServiceName", name);
            cmd.Parameters.AddWithValue("@ServiceType", type);
            cmd.Parameters.AddWithValue("@IsEmergency", emergency);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
