using System;
using AddressBookSystem.Services;
using AddressBookSystem.Exceptions;

namespace AddressBookSystem.UCs
{
    // UC-2: Edit Contact
    public class UC2_EditContact
    {
        public static void Execute(AddressBook book)
        {
            Console.Write("Enter First Name to edit: ");
            string name = Console.ReadLine();

            var person = book.GetContact(name);
            if (person == null)
                throw new ContactNotFoundException("Contact not found.");

            Console.Write("New City: "); person.City = Console.ReadLine();
            Console.Write("New State: "); person.State = Console.ReadLine();
        }
    }
}
