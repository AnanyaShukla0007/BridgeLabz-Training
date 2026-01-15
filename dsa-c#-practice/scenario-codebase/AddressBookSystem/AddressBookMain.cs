using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    class AddressBookMain
    {
        static void Main(string[] args)
        {
            // UC-1: Welcome message
            Console.WriteLine("Welcome to Address Book Program");

            AddressBook addressBook = new AddressBook();
            string choice;

            // UC-4: Add multiple contacts
            do
            {
                ContactPerson person = new ContactPerson();

                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter City: ");
                person.City = Console.ReadLine();

                Console.Write("Enter State: ");
                person.State = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                person.PhoneNumber = Console.ReadLine();

                addressBook.AddContact(person);

                Console.Write("Add another contact? (yes/no): ");
                choice = Console.ReadLine();

            } while (choice.Equals("yes"));

            // UC-4: Display all contacts
            addressBook.DisplayAllContacts();
        }
    }
}
