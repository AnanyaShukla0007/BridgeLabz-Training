using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // AddressBook class manages contact operations
    class AddressBook
    {
        // UC-1: Stores a single contact
        private ContactPerson contact;

        // UC-1: Add a new contact
        public void AddContact(ContactPerson person)
        {
            contact = person;
            Console.WriteLine("\nContact added successfully!");
        }

        // UC-2: Edit contact using First Name
        public void EditContact(string firstName)
        {
            if (contact != null && contact.FirstName.Equals(firstName))
            {
                Console.Write("Enter New Address: ");
                contact.Address = Console.ReadLine();

                Console.Write("Enter New City: ");
                contact.City = Console.ReadLine();

                Console.Write("Enter New State: ");
                contact.State = Console.ReadLine();

                Console.Write("Enter New Zip: ");
                contact.Zip = Console.ReadLine();

                Console.Write("Enter New Phone Number: ");
                contact.PhoneNumber = Console.ReadLine();

                Console.Write("Enter New Email: ");
                contact.Email = Console.ReadLine();

                Console.WriteLine("\nContact updated successfully!");
            }
            else
            {
                Console.WriteLine("\nContact not found!");
            }
        }

        // UC-3: Delete contact using First Name
        public void DeleteContact(string firstName)
        {
            if (contact != null && contact.FirstName.Equals(firstName))
            {
                contact = null;
                Console.WriteLine("\nContact deleted successfully!");
            }
            else
            {
                Console.WriteLine("\nContact not found!");
            }
        }

        // UC-1 & UC-2: Display contact details
        public void DisplayContact()
        {
            if (contact == null)
            {
                Console.WriteLine("\nNo contact to display.");
                return;
            }

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
