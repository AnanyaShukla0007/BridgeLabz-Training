using System.Data;
using Microsoft.Data.SqlClient;


namespace TechVille.DataAccess
{
    public static class CitizenRepository
    {
        public static void InsertCitizen(string code, string name, int age, decimal income, int years, string zone)
        {
            using SqlConnection con = new SqlConnection(DBConfig.ConnectionString);
            using SqlCommand cmd = new SqlCommand("sp_InsertCitizen", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CitizenCode", code);
            cmd.Parameters.AddWithValue("@FullName", name);
            cmd.Parameters.AddWithValue("@Age", age);
            cmd.Parameters.AddWithValue("@Income", income);
            cmd.Parameters.AddWithValue("@ResidencyYears", years);
            cmd.Parameters.AddWithValue("@Zone", zone);

            con.Open();
            cmd.ExecuteNonQuery();
        }

        public static SqlDataReader GetCitizen(string code)
        {
            SqlConnection con = new SqlConnection(DBConfig.ConnectionString);
            SqlCommand cmd = new SqlCommand("sp_GetCitizen", con);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@CitizenCode", code);

            con.Open();
            return cmd.ExecuteReader(CommandBehavior.CloseConnection);
        }
    }
}
