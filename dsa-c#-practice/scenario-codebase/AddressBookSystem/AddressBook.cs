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

    // UC-5: AddressBook with unique name
    class AddressBook
    {
        public string AddressBookName { get; set; }   // UC-5

        private ContactNode head = null;

        // UC-4: Add contact
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
                    temp = temp.Next;

                temp.Next = newNode;
            }
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
