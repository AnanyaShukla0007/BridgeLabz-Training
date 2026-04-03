using System;

namespace AeroVigil.Exceptions
{
    internal class InvalidFlightException : Exception
    {
        public InvalidFlightException(string message) : base(message)
        {
        }
    }
}
