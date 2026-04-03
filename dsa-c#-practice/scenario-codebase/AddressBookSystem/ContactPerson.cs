using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
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

        // UC-7: Equals override
        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is ContactPerson))
                return false;

            ContactPerson other = (ContactPerson)obj;
            return FirstName.Equals(other.FirstName)
                && LastName.Equals(other.LastName);
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName).GetHashCode();
        }

        // UC-10: Override ToString for printing
        public override string ToString()
        {
            return FirstName + " " + LastName + " | "
                 + City + " | "
                 + State + " | "
                 + PhoneNumber;
        }
    }
}
