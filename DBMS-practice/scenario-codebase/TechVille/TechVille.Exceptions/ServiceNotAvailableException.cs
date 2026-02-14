using System;

namespace TechVille.Exceptions
{
    public class ServiceNotAvailableException : Exception
    {
        public ServiceNotAvailableException(string message) : base(message) { }
    }
}
