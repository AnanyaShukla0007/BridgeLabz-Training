using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddressBookSystem
{
    // Custom Exception – UC-6 / UC-7
    class DuplicateContactException : Exception
    {
        public DuplicateContactException(string message) : base(message) { }
    }

    class AddressBook
    {
        public string AddressBookName { get; set; }

        // UC-4: Multiple contacts using Collection
        private List<ContactPerson> contacts = new List<ContactPerson>();

        // UC-6 & UC-7: Add contact with duplicate prevention
        public void AddContact(ContactPerson person)
        {
            if (contacts.Contains(person))
                throw new DuplicateContactException("Duplicate contact entry not allowed.");

            contacts.Add(person);
        }

        // UC-2: Edit contact
        public void EditContact(string firstName)
        {
            ContactPerson person = contacts.Find(p => p.FirstName.Equals(firstName));

            if (person == null)
                throw new Exception("Contact not found.");

            Console.Write("Enter New City: ");
            person.City = Console.ReadLine();

            Console.Write("Enter New State: ");
            person.State = Console.ReadLine();

            Console.Write("Enter New Phone: ");
            person.PhoneNumber = Console.ReadLine();
        }

        // UC-3: Delete contact
        public void DeleteContact(string firstName)
        {
            ContactPerson person = contacts.Find(p => p.FirstName.Equals(firstName));

            if (person == null)
                throw new Exception("Contact not found.");

            contacts.Remove(person);
        }

        // UC-10: Sort by name
        public void SortByName()
        {
            contacts.Sort((a, b) => a.FirstName.CompareTo(b.FirstName));
        }

        // UC-11: Sort by City / State / Zip
        public void SortByCity() => contacts.Sort((a, b) => a.City.CompareTo(b.City));
        public void SortByState() => contacts.Sort((a, b) => a.State.CompareTo(b.State));
        public void SortByZip() => contacts.Sort((a, b) => a.Zip.CompareTo(b.Zip));

        // UC-4 / UC-10 / UC-11: Display
        public void DisplayContacts()
        {
            Console.WriteLine($"\nAddress Book: {AddressBookName}");
            foreach (var person in contacts)
                Console.WriteLine(person);
        }

        // UC-8 & UC-9 helper
        public List<ContactPerson> GetContacts()
        {
            return contacts;
        }
    }
}
