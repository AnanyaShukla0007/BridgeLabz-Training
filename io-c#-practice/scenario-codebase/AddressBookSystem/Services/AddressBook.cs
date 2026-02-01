using System.Collections.Generic;
using AddressBookSystem.Models;
using AddressBookSystem.Exceptions;

namespace AddressBookSystem.Services
{
    // SERVICE CLASS (Business Logic)
    public class AddressBook
    {
        private List<ContactPerson> contacts = new List<ContactPerson>();

        // UC-1: Add contact
        public void AddContact(ContactPerson person)
        {
            if (contacts.Contains(person))
                throw new DuplicateContactException("Duplicate contact not allowed.");
            contacts.Add(person);
        }

        // UC-2: Get contact
        public ContactPerson GetContact(string firstName)
        {
            return contacts.Find(c => c.FirstName == firstName);
        }

        // UC-3: Delete contact
        public void RemoveContact(ContactPerson person)
        {
            contacts.Remove(person);
        }

        // UC-10 & UC-11: Sorting
        public void SortByName() => contacts.Sort((a,b)=>a.FirstName.CompareTo(b.FirstName));
        public void SortByCity() => contacts.Sort((a,b)=>a.City.CompareTo(b.City));
        public void SortByState() => contacts.Sort((a,b)=>a.State.CompareTo(b.State));
        public void SortByZip() => contacts.Sort((a,b)=>a.Zip.CompareTo(b.Zip));

        // Utility
        public List<ContactPerson> GetAllContacts() => contacts;
    }
}
