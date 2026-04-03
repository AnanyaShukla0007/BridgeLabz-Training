using System;
using System.Data;
using Microsoft.Data.SqlClient;

using HealthClinicApp.Core.Exceptions;

namespace HealthClinicApp.DataAccess
{
    /// <summary>
    /// Executes stored procedures against SQL Server.
    /// No inline SQL is allowed here.
    /// </summary>
    public static class SqlExecutor
    {
        /// <summary>
        /// Executes a stored procedure that returns no result set.
        /// Example: INSERT, UPDATE
        /// </summary>
        public static void ExecuteNonQuery(
            string storedProcedureName,
            params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = DbConnectionFactory.CreateConnection())
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new ClinicException(
                    $"Database error while executing {storedProcedureName}: {ex.Message}"
                );
            }
        }

        /// <summary>
        /// Executes a stored procedure that returns a result set.
        /// Example: SELECT
        /// </summary>
        public static DataTable ExecuteQuery(
            string storedProcedureName,
            params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = DbConnectionFactory.CreateConnection())
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    using (var adapter = new SqlDataAdapter(command))
                    {
                        var table = new DataTable();
                        adapter.Fill(table);
                        return table;
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ClinicException(
                    $"Database error while executing {storedProcedureName}: {ex.Message}"
                );
            }
        }

        /// <summary>
        /// Executes a stored procedure and returns a single scalar value.
        /// </summary>
        public static object ExecuteScalar(
            string storedProcedureName,
            params SqlParameter[] parameters)
        {
            try
            {
                using (var connection = DbConnectionFactory.CreateConnection())
                using (var command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;

                    if (parameters != null)
                        command.Parameters.AddRange(parameters);

                    connection.Open();
                    return command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                throw new ClinicException(
                    $"Database error while executing {storedProcedureName}: {ex.Message}"
                );
            }
        }
    }
}
