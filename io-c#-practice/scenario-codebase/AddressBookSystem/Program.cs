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
                Console.WriteLine("1. Add Contact (UC-1)");
                Console.WriteLine("2. Edit Contact (UC-2)");
                Console.WriteLine("3. Delete Contact (UC-3)");
                Console.WriteLine("4. Sort Contacts (UC-10 & UC-11)");
                Console.WriteLine("5. Save to File / CSV / JSON (UC-12,13,14)");
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
