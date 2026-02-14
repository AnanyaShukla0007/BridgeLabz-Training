using System;

namespace HealthClinicApp.Core.Exceptions
{
    /// <summary>
    /// Base exception for all clinic-related errors.
    /// Any unexpected or invalid business operation
    /// should throw this exception or its derived types.
    /// </summary>
    public class ClinicException : Exception
    {
        public ClinicException()
        {
        }

        public ClinicException(string message)
            : base(message)
        {
        }

        public ClinicException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
