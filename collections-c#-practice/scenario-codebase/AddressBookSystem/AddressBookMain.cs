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

            // UC-5: Multiple Address Books using Dictionary
            Dictionary<string, AddressBook> system = new Dictionary<string, AddressBook>();

            try
            {
                Console.Write("Enter Address Book Name: ");
                string bookName = Console.ReadLine();

                if (system.ContainsKey(bookName))
                    throw new Exception("Duplicate Address Book not allowed.");

                AddressBook book = new AddressBook { AddressBookName = bookName };
                system.Add(bookName, book);

                ContactPerson person = new ContactPerson();

                Console.Write("Enter First Name: ");
                person.FirstName = Console.ReadLine();

                Console.Write("Enter Last Name: ");
                person.LastName = Console.ReadLine();

                Console.Write("Enter City: ");
                person.City = Console.ReadLine();

                Console.Write("Enter State: ");
                person.State = Console.ReadLine();

                Console.Write("Enter Zip: ");
                person.Zip = Console.ReadLine();

                Console.Write("Enter Phone Number: ");
                person.PhoneNumber = Console.ReadLine();

                book.AddContact(person); // UC-6 / UC-7

                book.SortByName();       // UC-10
                book.DisplayContacts();  // UC-10
            }
            catch (DuplicateContactException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
        }
    }
}
