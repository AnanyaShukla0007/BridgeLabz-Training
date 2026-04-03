using System;
using AddressBookSystem.Services;

namespace AddressBookSystem.UCs
{
    public class UC10_SortByName
    {
        public static void Execute(AddressBook book)
        {
            book.SortByName();
            Console.WriteLine("Contacts sorted by name.");
        }
    }
}
