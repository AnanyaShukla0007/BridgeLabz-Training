using System;
using AddressBookSystem.Models;
using AddressBookSystem.Services;

namespace AddressBookSystem.UCs
{
    // UC-1: Add new Contact
    public class UC1_AddContact
    {
        public static void Execute(AddressBook book)
        {
            ContactPerson p = new ContactPerson();

            Console.Write("First Name: "); p.FirstName = Console.ReadLine();
            Console.Write("Last Name: "); p.LastName = Console.ReadLine();
            Console.Write("Address: "); p.Address = Console.ReadLine();
            Console.Write("City: "); p.City = Console.ReadLine();
            Console.Write("State: "); p.State = Console.ReadLine();
            Console.Write("Zip: "); p.Zip = Console.ReadLine();
            Console.Write("Phone: "); p.PhoneNumber = Console.ReadLine();
            Console.Write("Email: "); p.Email = Console.ReadLine();

            book.AddContact(p);
            Console.WriteLine("Contact Added.");
        }
    }
}
