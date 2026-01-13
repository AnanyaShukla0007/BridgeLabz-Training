using System;

namespace BridgeLabzTraning.BookBuddy
{
    internal class BookMenu
    {
        private IBookActions actions = new BookUtility();

        public void Start()
        {
            int choice;
            do
            {
                Console.WriteLine("\n1.Add  2.Search by Author  3.Sort  4.Export  5.Exit");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        actions.AddBook();
                        break;
                    case 2:
                        actions.SearchByAuthor();
                        break;
                    case 3:
                        actions.SortBooks();
                        break;
                    case 4:
                        actions.ExportBooks();
                        break;
                }
            } while (choice != 5);
        }
    }
}
