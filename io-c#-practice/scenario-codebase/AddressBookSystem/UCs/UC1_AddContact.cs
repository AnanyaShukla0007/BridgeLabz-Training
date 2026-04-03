using System;
using AddressBookSystem.Models;
using AddressBookSystem.Services;
using AddressBookSystem.Validation;

namespace AddressBookSystem.UCs
{
    // UC-1: Add Contact with REGEX + Annotations + Reflection validation
    public class UC1_AddContact
    {
        public static void Execute(AddressBook book)
        {
            ContactPerson person = new ContactPerson();

            Console.Write("First Name: ");
            person.FirstName = Console.ReadLine() ?? "";

            Console.Write("Last Name: ");
            person.LastName = Console.ReadLine() ?? "";

            Console.Write("Address: ");
            person.Address = Console.ReadLine() ?? "";

            Console.Write("City: ");
            person.City = Console.ReadLine() ?? "";

            Console.Write("State: ");
            person.State = Console.ReadLine() ?? "";

            Console.Write("Zip: ");
            person.Zip = Console.ReadLine() ?? "";

            Console.Write("Phone Number: ");
            person.PhoneNumber = Console.ReadLine() ?? "";

            Console.Write("Email: ");
            person.Email = Console.ReadLine() ?? "";

            // Reflection + DataAnnotations validation
            ObjectValidator.Validate(person);

            book.AddContact(person);
            Console.WriteLine("Contact added successfully.");
        }
    }
}
