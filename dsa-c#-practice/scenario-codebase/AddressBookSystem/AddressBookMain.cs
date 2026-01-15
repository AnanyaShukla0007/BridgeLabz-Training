using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // UC-5: Node for AddressBook Linked List
    class AddressBookNode
    {
        public AddressBook Data;
        public AddressBookNode Next;

        public AddressBookNode(AddressBook book)
        {
            Data = book;
            Next = null;
        }
    }

    // UC-5: AddressBookSystem manages multiple AddressBooks
    class AddressBookSystem
    {
        private AddressBookNode head = null;

        // UC-5: Add new Address Book
        public void AddAddressBook(AddressBook book)
        {
            AddressBookNode newNode = new AddressBookNode(book);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                AddressBookNode temp = head;
                while (temp.Next != null)
                    temp = temp.Next;

                temp.Next = newNode;
            }
        }

        // UC-5: Display all Address Books
        public void DisplayAllAddressBooks()
        {
            if (head == null)
            {
                Console.WriteLine("No Address Books found.");
                return;
            }

            AddressBookNode temp = head;
            while (temp != null)
            {
                temp.Data.DisplayContacts();
                temp = temp.Next;
            }
        }
    }

    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AddressBookSystem system = new AddressBookSystem();
            string choice;

            // UC-5: Add multiple Address Books
            do
            {
                AddressBook book = new AddressBook();

                Console.Write("\nEnter Address Book Name: ");
                book.AddressBookName = Console.ReadLine();

                string addContactChoice;
                do
                {
                    ContactPerson person = new ContactPerson();

                    Console.Write("Enter First Name: ");
                    person.FirstName = Console.ReadLine();

                    Console.Write("Enter Last Name: ");
                    person.LastName = Console.ReadLine();

                    Console.Write("Enter City: ");
                    person.City = Console.ReadLine();

                    Console.Write("Enter Phone Number: ");
                    person.PhoneNumber = Console.ReadLine();

                    book.AddContact(person);

                    Console.Write("Add another contact to this Address Book? (yes/no): ");
                    addContactChoice = Console.ReadLine();

                } while (addContactChoice.Equals("yes"));

                system.AddAddressBook(book);

                Console.Write("Add another Address Book? (yes/no): ");
                choice = Console.ReadLine();

            } while (choice.Equals("yes"));

            // UC-5: Display all Address Books
            system.DisplayAllAddressBooks();
        }
    }
}
