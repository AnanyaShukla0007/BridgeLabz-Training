using System;

namespace TechVille.Exceptions
{
    public class UnderageException : Exception
    {
        public UnderageException(string message) : base(message) { }
    }
}
