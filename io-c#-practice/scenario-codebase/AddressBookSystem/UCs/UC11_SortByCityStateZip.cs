using System;
using AddressBookSystem.Services;

namespace AddressBookSystem.UCs
{
    public class UC11_SortByCityStateZip
    {
        public static void Execute(AddressBook book)
        {
            Console.WriteLine("1. Sort by City");
            Console.WriteLine("2. Sort by State");
            Console.WriteLine("3. Sort by Zip");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    book.SortByCity();
                    Console.WriteLine("Sorted by City");
                    break;
                case "2":
                    book.SortByState();
                    Console.WriteLine("Sorted by State");
                    break;
                case "3":
                    book.SortByZip();
                    Console.WriteLine("Sorted by Zip");
                    break;
            }
        }
    }
}
