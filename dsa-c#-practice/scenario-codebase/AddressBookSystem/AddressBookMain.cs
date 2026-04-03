using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
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

    class AddressBookSystem
    {
        private AddressBookNode head = null;

        public void AddAddressBook(AddressBook book)
        {
            AddressBookNode newNode = new AddressBookNode(book);

            if (head == null)
                head = newNode;
            else
            {
                AddressBookNode temp = head;
                while (temp.Next != null)
                    temp = temp.Next;

                temp.Next = newNode;
            }
        }

        // UC-8: Search person by City or State
        public void SearchPersonByCityOrState(string value)
        {
            AddressBookNode bookNode = head;
            bool found = false;

            while (bookNode != null)
            {
                ContactNode contactNode = bookNode.Data.GetHead();

                while (contactNode != null)
                {
                    if (contactNode.Data.City.Equals(value)
                        || contactNode.Data.State.Equals(value))
                    {
                        Console.WriteLine(
                            contactNode.Data.FirstName + " " +
                            contactNode.Data.LastName + " | " +
                            contactNode.Data.City + " | " +
                            contactNode.Data.State + " | " +
                            "AddressBook: " + bookNode.Data.AddressBookName
                        );
                        found = true;
                    }
                    contactNode = contactNode.Next;
                }
                bookNode = bookNode.Next;
            }

            if (!found)
                Console.WriteLine("No persons found.");
        }

        // UC-9: Count persons by City or State
        public void CountPersonByCityOrState(string value)
        {
            int count = 0;
            AddressBookNode bookNode = head;

            while (bookNode != null)
            {
                ContactNode contactNode = bookNode.Data.GetHead();

                while (contactNode != null)
                {
                    if (contactNode.Data.City.Equals(value)
                        || contactNode.Data.State.Equals(value))
                    {
                        count++;
                    }
                    contactNode = contactNode.Next;
                }
                bookNode = bookNode.Next;
            }

            Console.WriteLine(
                "Number of persons in " + value + " = " + count
            );
        }
    }

    class AddressBookMain
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Address Book Program");

            AddressBookSystem system = new AddressBookSystem();

            // (Assume AddressBooks + Contacts already added from UC-5 flow)

            Console.Write("\nEnter City or State to count persons: ");
            string value = Console.ReadLine();

            // UC-9: Count result
            system.CountPersonByCityOrState(value);
        }
    }
}
