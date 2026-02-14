using System;

namespace HealthClinicApp.Core.Exceptions
{
    /// <summary>
    /// Represents authorization and access control errors.
    /// Thrown when a user attempts an action without proper permissions.
    /// </summary>
    public class AuthorizationException : ClinicException
    {
        public AuthorizationException()
        {
        }

        public AuthorizationException(string message)
            : base(message)
        {
        }

        public AuthorizationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
