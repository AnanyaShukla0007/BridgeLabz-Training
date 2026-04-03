using System;
using AddressBookSystem.Services;
using AddressBookSystem.Exceptions;

namespace AddressBookSystem.UCs
{
    // UC-3: Delete Contact using First Name
    public class UC3_DeleteContact
    {
        public static void Execute(AddressBook book)
        {
            Console.Write("Enter First Name to delete: ");
            string name = Console.ReadLine() ?? "";

            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Name cannot be empty");

            var person = book.GetContact(name);

            if (person == null)
                throw new ContactNotFoundException("Contact not found.");

            book.RemoveContact(person);
            Console.WriteLine("Contact deleted successfully.");
        }
    }
}
