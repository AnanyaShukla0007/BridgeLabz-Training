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
            // UC-1: Display welcome message
            Console.WriteLine("Welcome to Address Book Program");

            AddressBook addressBook = new AddressBook();
            ContactPerson person = new ContactPerson();

            // UC-1: Take contact details from user
            Console.Write("Enter First Name: ");
            person.FirstName = Console.ReadLine();

            Console.Write("Enter Last Name: ");
            person.LastName = Console.ReadLine();

            Console.Write("Enter Address: ");
            person.Address = Console.ReadLine();

            Console.Write("Enter City: ");
            person.City = Console.ReadLine();

            Console.Write("Enter State: ");
            person.State = Console.ReadLine();

            Console.Write("Enter Zip: ");
            person.Zip = Console.ReadLine();

            Console.Write("Enter Phone Number: ");
            person.PhoneNumber = Console.ReadLine();

            Console.Write("Enter Email: ");
            person.Email = Console.ReadLine();

            // UC-1: Add contact to Address Book
            addressBook.AddContact(person);

            // UC-1: Display added contact
            addressBook.DisplayContact();

            // UC-2: Edit existing contact using first name
            Console.Write("\nEnter First Name to Edit Contact: ");
            string editName = Console.ReadLine();

            addressBook.EditContact(editName);

            // UC-2: Display updated contact
            addressBook.DisplayContact();
        }
    }
}
