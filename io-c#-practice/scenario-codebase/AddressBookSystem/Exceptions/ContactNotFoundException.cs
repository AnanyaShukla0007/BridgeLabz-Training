using System;

namespace AddressBookSystem.Exceptions
{
    // UC-2 & UC-3: Custom exception when contact is missing
    public class ContactNotFoundException : Exception
    {
        public ContactNotFoundException(string message) : base(message) { }
    }
}
