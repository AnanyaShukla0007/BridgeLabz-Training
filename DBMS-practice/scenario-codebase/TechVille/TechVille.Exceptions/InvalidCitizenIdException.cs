using System;

namespace TechVille.Exceptions
{
    public class InvalidCitizenIdException : Exception
    {
        public InvalidCitizenIdException(string message) : base(message) { }
    }
}
