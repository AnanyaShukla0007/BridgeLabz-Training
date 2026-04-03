using System;
using AddressBookSystem.Services;

namespace AddressBookSystem.UCs
{
    // UC-10 & UC-11: Sorting Menu
    public class UC10_11_SortMenu
    {
        public static void Execute(AddressBook book)
        {
            Console.WriteLine("1. Sort by Name");
            Console.WriteLine("2. Sort by City");
            Console.WriteLine("3. Sort by State");
            Console.WriteLine("4. Sort by Zip");

            string ch = Console.ReadLine() ?? "";

            switch (ch)
            {
                case "1": book.SortByName(); break;
                case "2": book.SortByCity(); break;
                case "3": book.SortByState(); break;
                case "4": book.SortByZip(); break;
                default: Console.WriteLine("Invalid choice"); break;
            }

            Console.WriteLine("Sorted Successfully.");
        }
    }
}
