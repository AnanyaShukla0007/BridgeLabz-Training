using System.Collections.Generic;

namespace AddressBookSystem.Services
{
    public class AddressBookSystemService
    {
        private Dictionary<string, AddressBook> books = new Dictionary<string, AddressBook>();

        public void AddAddressBook(string name)
        {
            if (!books.ContainsKey(name))
                books.Add(name, new AddressBook());
        }

        public AddressBook GetAddressBook(string name)
        {
            return books[name];
        }
    }
}
