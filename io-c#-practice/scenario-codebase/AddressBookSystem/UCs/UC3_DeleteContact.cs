using System;
using AddressBookSystem.Services;
using AddressBookSystem.Exceptions;

namespace AddressBookSystem.UCs
{
    // UC-3: Delete Contact
    public class UC3_DeleteContact
    {
        public static void Execute(AddressBook book)
        {
            Console.Write("Enter First Name to delete: ");
            string name = Console.ReadLine();

            var person = book.GetContact(name);
            if (person == null)
                throw new ContactNotFoundException("Contact not found.");

            book.RemoveContact(person);
            Console.WriteLine("Contact Deleted.");
        }
    }
}
