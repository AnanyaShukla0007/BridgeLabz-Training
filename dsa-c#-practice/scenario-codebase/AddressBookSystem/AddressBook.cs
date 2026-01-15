using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // UC-4: Node class for Contact Linked List
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

    // UC-5, UC-6, UC-7, UC-8: AddressBook class
    class AddressBook
    {
        // UC-5: Unique name for Address Book
        public string AddressBookName { get; set; }

        // UC-4: Head of Contact Linked List
        private ContactNode head = null;

        // UC-7: Check duplicate contact using Equals()
        private bool IsDuplicate(ContactPerson person)
        {
            ContactNode temp = head;

            while (temp != null)
            {
                if (temp.Data.Equals(person))
                {
                    return true;
                }
                temp = temp.Next;
            }
            return false;
        }

        // UC-4 & UC-6 & UC-7: Add contact with duplicate prevention
        public void AddContact(ContactPerson person)
        {
            if (IsDuplicate(person))
            {
                Console.WriteLine("Duplicate contact found. Entry not allowed.");
                return;
            }

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

            Console.WriteLine("Contact added successfully.");
        }

        // UC-4: Display all contacts in this Address Book
        public void DisplayContacts()
        {
            Console.WriteLine("\nAddress Book: " + AddressBookName);

            if (head == null)
            {
                Console.WriteLine("No contacts available.");
                return;
            }

            ContactNode temp = head;
            while (temp != null)
            {
                Console.WriteLine(
                    temp.Data.FirstName + " " +
                    temp.Data.LastName + " | " +
                    temp.Data.City + " | " +
                    temp.Data.State + " | " +
                    temp.Data.PhoneNumber
                );
                temp = temp.Next;
            }
        }

        // UC-8 helper: expose head for traversal across Address Books
        public ContactNode GetHead()
        {
            return head;
        }
    }
}
