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
            Console.WriteLine("Welcome to Address Book Program");

            ContactPerson person = new ContactPerson();

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

            AddressBook addressBook = new AddressBook();
            addressBook.AddContact(person);
            addressBook.DisplayContact();
        }
    }
}
