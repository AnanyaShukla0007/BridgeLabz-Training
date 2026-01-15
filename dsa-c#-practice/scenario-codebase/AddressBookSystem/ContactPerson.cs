using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // UC-1 & UC-7: Represents a single contact person
    class ContactPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }

        // UC-7: Override Equals to check duplicate person
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is ContactPerson))
                return false;

            ContactPerson other = (ContactPerson)obj;

            return this.FirstName.Equals(other.FirstName)
                && this.LastName.Equals(other.LastName);
        }

        // UC-7: Override GetHashCode (rule: Equals + GetHashCode together)
        public override int GetHashCode()
        {
            return (FirstName + LastName).GetHashCode();
        }
    }
}
