using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // UC-4: Node class for Linked List
    class ContactNode
    {
        public ContactPerson Data;
        public ContactNode Next;

        public ContactNode(ContactPerson person)
        {
            Data = person;
            Next = null;
        }
    }

    // AddressBook handles all contact operations
    class AddressBook
    {
        // UC-4: Head node of Linked List
        private ContactNode head = null;

        // UC-1 & UC-4: Add contact to Address Book
        public void AddContact(ContactPerson person)
        {
            ContactNode newNode = new ContactNode(person);

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                ContactNode temp = head;
                while (temp.Next != null)
                {
                    temp = temp.Next;
                }
                temp.Next = newNode;
            }

            Console.WriteLine("Contact added successfully!");
        }

        // UC-2: Edit contact using First Name
        public void EditContact(string firstName)
        {
            ContactNode temp = head;

            while (temp != null)
            {
                if (temp.Data.FirstName.Equals(firstName))
                {
                    Console.Write("Enter New City: ");
                    temp.Data.City = Console.ReadLine();

                    Console.Write("Enter New State: ");
                    temp.Data.State = Console.ReadLine();

                    Console.Write("Enter New Phone Number: ");
                    temp.Data.PhoneNumber = Console.ReadLine();

                    Console.WriteLine("Contact updated successfully!");
                    return;
                }
                temp = temp.Next;
            }

            Console.WriteLine("Contact not found!");
        }

        // UC-3: Delete contact using First Name
        public void DeleteContact(string firstName)
        {
            if (head == null)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            if (head.Data.FirstName.Equals(firstName))
            {
                head = head.Next;
                Console.WriteLine("Contact deleted successfully!");
                return;
            }

            ContactNode prev = head;
            ContactNode curr = head.Next;

            while (curr != null)
            {
                if (curr.Data.FirstName.Equals(firstName))
                {
                    prev.Next = curr.Next;
                    Console.WriteLine("Contact deleted successfully!");
                    return;
                }
                prev = curr;
                curr = curr.Next;
            }

            Console.WriteLine("Contact not found!");
        }

        // UC-4: Display all contacts
        public void DisplayAllContacts()
        {
            if (head == null)
            {
                Console.WriteLine("No contacts to display.");
                return;
            }

            Console.WriteLine("\n--- Address Book Contacts ---");
            ContactNode temp = head;

            while (temp != null)
            {
                Console.WriteLine(
                    temp.Data.FirstName + " " +
                    temp.Data.LastName + " | " +
                    temp.Data.City + " | " +
                    temp.Data.PhoneNumber
                );
                temp = temp.Next;
            }
        }
    }
}
