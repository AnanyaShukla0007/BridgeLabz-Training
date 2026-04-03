using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
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

    class AddressBook
    {
        public string AddressBookName { get; set; }
        private ContactNode head = null;

        // UC-7: Duplicate check
        private bool IsDuplicate(ContactPerson person)
        {
            ContactNode temp = head;
            while (temp != null)
            {
                if (temp.Data.Equals(person))
                    return true;
                temp = temp.Next;
            }
            return false;
        }

        // UC-4 / UC-6 / UC-7
        public void AddContact(ContactPerson person)
        {
            if (IsDuplicate(person))
            {
                Console.WriteLine("Duplicate contact found.");
                return;
            }

            ContactNode newNode = new ContactNode(person);

            if (head == null)
                head = newNode;
            else
            {
                ContactNode temp = head;
                while (temp.Next != null)
                    temp = temp.Next;
                temp.Next = newNode;
            }
        }

        // UC-10: Sort by First Name
        public void SortContactsByName()
        {
            BubbleSort((a, b) => string.Compare(a.FirstName, b.FirstName));
        }

        // UC-11: Sort by City
        public void SortContactsByCity()
        {
            BubbleSort((a, b) => string.Compare(a.City, b.City));
        }

        // UC-11: Sort by State
        public void SortContactsByState()
        {
            BubbleSort((a, b) => string.Compare(a.State, b.State));
        }

        // UC-11: Sort by Zip
        public void SortContactsByZip()
        {
            BubbleSort((a, b) => string.Compare(a.Zip, b.Zip));
        }

        // Shared Bubble Sort logic (DSA)
        private void BubbleSort(Func<ContactPerson, ContactPerson, int> compare)
        {
            if (head == null || head.Next == null)
                return;

            bool swapped;
            do
            {
                swapped = false;
                ContactNode current = head;

                while (current.Next != null)
                {
                    if (compare(current.Data, current.Next.Data) > 0)
                    {
                        ContactPerson temp = current.Data;
                        current.Data = current.Next.Data;
                        current.Next.Data = temp;
                        swapped = true;
                    }
                    current = current.Next;
                }
            } while (swapped);
        }

        // UC-4 / UC-10 / UC-11
        public void DisplayContacts()
        {
            Console.WriteLine("\nAddress Book: " + AddressBookName);
            ContactNode temp = head;

            while (temp != null)
            {
                Console.WriteLine(temp.Data.ToString());
                temp = temp.Next;
            }
        }

        // UC-8 helper
        public ContactNode GetHead()
        {
            return head;
        }
    }
}
