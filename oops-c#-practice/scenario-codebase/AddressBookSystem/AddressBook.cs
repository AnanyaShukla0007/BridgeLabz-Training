using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBook
    {
        private ContactPerson contact;

        public void AddContact(ContactPerson person)
        {
            contact = person;
            Console.WriteLine("\nContact added successfully!");
        }

        public void DisplayContact()
        {
            Console.WriteLine("\n--- Contact Details ---");
            Console.WriteLine("Name: " + contact.FirstName + " " + contact.LastName);
            Console.WriteLine("Address: " + contact.Address);
            Console.WriteLine("City: " + contact.City);
            Console.WriteLine("State: " + contact.State);
            Console.WriteLine("Zip: " + contact.Zip);
            Console.WriteLine("Phone: " + contact.PhoneNumber);
            Console.WriteLine("Email: " + contact.Email);
        }
    }
}
