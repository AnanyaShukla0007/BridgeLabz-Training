using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // UC-4: Node for Contact Linked List
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

    // UC-5, UC-6, UC-7: AddressBook
    class AddressBook
    {
        public string AddressBookName { get; set; }

        private ContactNode head = null;

        // UC-7: Duplicate check using Equals()
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

        // UC-4 & UC-7: Add contact with object-based duplicate check
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
                    temp = temp.Next;

                temp.Next = newNode;
            }

            Console.WriteLine("Contact added successfully.");
        }

        // UC-4: Display contacts
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
                    temp.Data.PhoneNumber
                );
                temp = temp.Next;
            }
        }
    }
}
