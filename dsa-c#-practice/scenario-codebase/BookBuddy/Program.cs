using System;

namespace BridgeLabzTraning.BookBuddy
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Bookshelf shelf = new Bookshelf();
            int choice;

            do
            {
                Console.WriteLine("\n--- BookBuddy Menu ---");
                Console.WriteLine("1. Add Book");
                Console.WriteLine("2. Sort Books");
                Console.WriteLine("3. Search by Author");
                Console.WriteLine("4. Export Books");
                Console.WriteLine("5. Exit");

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Console.Write("Enter title: ");
                        string title = Console.ReadLine();
                        Console.Write("Enter author: ");
                        string author = Console.ReadLine();
                        shelf.AddBook(title, author);
                        break;

                    case 2:
                        shelf.SortBooksAlphabetically();
                        break;

                    case 3:
                        Console.Write("Enter author: ");
                        shelf.SearchByAuthor(Console.ReadLine());
                        break;

                    case 4:
                        shelf.ExportBooks();
                        break;
                }
            } while (choice != 5);
        }
    }
}
