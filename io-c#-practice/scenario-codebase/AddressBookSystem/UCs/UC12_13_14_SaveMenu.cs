using System;
using AddressBookSystem.Services;
using AddressBookSystem.IO;

namespace AddressBookSystem.UCs
{
    // UC-12, UC-13, UC-14: Save Menu
    public class UC12_13_14_SaveMenu
    {
        public static void Execute(AddressBook book)
        {
            Console.WriteLine("1. Save as Text File");
            Console.WriteLine("2. Save as CSV");
            Console.WriteLine("3. Save as JSON");

            string ch = Console.ReadLine();

            switch (ch)
            {
                case "1":
                    FileIOService.WriteText("Data/contacts.txt", book.GetAllContacts());
                    break;
                case "2":
                    CsvService.WriteCsv("Data/contacts.csv", book.GetAllContacts());
                    break;
                case "3":
                    JsonService.WriteJson("Data/contacts.json", book.GetAllContacts());
                    break;
            }

            Console.WriteLine("Data Saved.");
        }
    }
}
