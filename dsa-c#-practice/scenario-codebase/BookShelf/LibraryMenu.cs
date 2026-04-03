using System;

namespace BridgeLabzTraning.BookShelf
{
    internal class LibraryMenu
    {
        private ILibraryActions library;

        public LibraryMenu()
        {
            library = new LibraryUtility();
        }

        public void Start()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1.Add Book  2.Borrow Book  3.Display Catalog  4.Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        library.AddBook();
                        break;
                    case 2:
                        library.BorrowBook();
                        break;
                    case 3:
                        library.DisplayCatalog();
                        break;
                }
            } while (choice != 4);
        }
    }
}
