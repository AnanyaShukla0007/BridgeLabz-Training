using System;
using AddressBookSystem.Services;
using AddressBookSystem.UCs;

namespace AddressBookSystem
{
    // Entry point of application
    class Program
    {
        static void Main()
        {
            AddressBook book = new AddressBook();
            bool exit = false;

            // MENU DRIVEN PROGRAM
            while (!exit)
            {
                Console.WriteLine("\n===== ADDRESS BOOK MENU =====");
                Console.WriteLine("1. Add Contact");
                Console.WriteLine("2. Edit Contact");
                Console.WriteLine("3. Delete Contact");
                Console.WriteLine("4. Sort Contacts");
                Console.WriteLine("5. Save to File / CSV / JSON)");
                Console.WriteLine("6. Exit");
                Console.Write("Enter choice: ");

                string choice = Console.ReadLine() ?? "";

                try
                {
                    switch (choice)
                    {
                        case "1": UC1_AddContact.Execute(book); break;
                        case "2": UC2_EditContact.Execute(book); break;
                        case "3": UC3_DeleteContact.Execute(book); break;
                        case "4": UC10_11_SortMenu.Execute(book); break;
                        case "5": UC12_13_14_SaveMenu.Execute(book); break;
                        case "6": exit = true; break;
                        default: Console.WriteLine("Invalid choice."); break;
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
