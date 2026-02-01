using System;

namespace AddressBookSystem.Models
{
    // MODEL CLASS (Encapsulation)
    // UC-1: Represents a Contact Person
    public class ContactPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // UC-7: Override Equals for duplicate check
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is ContactPerson))
                return false;

            ContactPerson other = (ContactPerson)obj;
            return FirstName == other.FirstName && LastName == other.LastName;
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName).GetHashCode();
        }

        // UC-10: Clean printing
        public override string ToString()
        {
            return $"{FirstName} {LastName} | {City} | {State} | {Zip} | {PhoneNumber}";
        }
    }
}
