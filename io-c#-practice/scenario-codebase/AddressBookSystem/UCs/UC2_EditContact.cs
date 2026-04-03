using System;
using AddressBookSystem.Services;
using AddressBookSystem.Exceptions;

namespace AddressBookSystem.UCs
{
    // UC-2: Edit Contact using First Name
    public class UC2_EditContact
    {
        public static void Execute(AddressBook book)
        {
            Console.Write("Enter First Name to edit: ");
            string name = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Name cannot be empty");

            var person = book.GetContact(name);

            if (person == null)
                throw new ContactNotFoundException("Contact not found.");

            Console.Write("New City: ");
            person.City = Console.ReadLine() ?? person.City;

            Console.Write("New State: ");
            person.State = Console.ReadLine() ?? person.State;

            Console.WriteLine("Contact updated successfully.");
        }
    }
}
