using Microsoft.Data.SqlClient;


namespace HealthClinicApp.DataAccess
{
    /// <summary>
    /// Responsible for creating SQL connections.
    /// This class does NOT execute commands.
    /// </summary>
    public static class DbConnectionFactory
    {
        /// <summary>
        /// Creates and returns a new SqlConnection.
        /// The caller is responsible for opening and closing it.
        /// </summary>
        public static SqlConnection CreateConnection()
        {
            var connectionString = DbConfig.GetConnectionString();
            return new SqlConnection(connectionString);
        }
    }
}
