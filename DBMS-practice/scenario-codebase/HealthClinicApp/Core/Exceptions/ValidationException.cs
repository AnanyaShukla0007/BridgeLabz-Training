using System;

namespace HealthClinicApp.Core.Exceptions
{
    /// <summary>
    /// Represents errors caused by invalid user input or data validation failures.
    /// This exception is thrown when business validation rules are violated.
    /// </summary>
    public class ValidationException : ClinicException
    {
        public ValidationException()
        {
        }

        public ValidationException(string message)
            : base(message)
        {
        }

        public ValidationException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
