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
            ContactPerson person = new ContactPerson();

            // UC-1: Take input for new contact
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

            // UC-1: Add contact
            addressBook.AddContact(person);
            addressBook.DisplayContact();

            // UC-2: Edit contact
            Console.Write("\nEnter First Name to Edit Contact: ");
            string editName = Console.ReadLine();
            addressBook.EditContact(editName);
            addressBook.DisplayContact();

            // UC-3: Delete contact
            Console.Write("\nEnter First Name to Delete Contact: ");
            string deleteName = Console.ReadLine();
            addressBook.DeleteContact(deleteName);
            addressBook.DisplayContact();
        }
    }
}
