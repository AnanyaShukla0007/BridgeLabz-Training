using System.Data;
using Microsoft.Data.SqlClient;


namespace TechVille.DataAccess
{
    public static class LogRepository
    {
        public static void Log(string message, string type)
        {
            using SqlConnection con = new SqlConnection(DBConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_LogError", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@ErrorMessage", message);
            cmd.Parameters.AddWithValue("@ErrorType", type);

            con.Open();
            cmd.ExecuteNonQuery();
        }
    }
}
