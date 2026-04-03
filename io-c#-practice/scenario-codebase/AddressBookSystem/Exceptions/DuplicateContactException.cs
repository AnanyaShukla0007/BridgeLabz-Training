using System;

namespace AddressBookSystem.Exceptions
{
    // UC-6 & UC-7: Custom exception for duplicate contact
    public class DuplicateContactException : Exception
    {
        public DuplicateContactException(string message) : base(message) { }
    }
}
