namespace HealthClinicApp.DataAccess
{
    /// <summary>
    /// Central place for SQL Server connection configuration.
    /// Uses Windows Authentication.
    /// </summary>
    public static class DbConfig
    {
        /// <summary>
        /// Returns the SQL Server connection string.
        /// </summary>
        public static string GetConnectionString()
        {
            return "Server=ANANYA\\SQLEXPRESS;Database=HealthClinicDB;Trusted_Connection=True;TrustServerCertificate=True;";
        }
    }
}
