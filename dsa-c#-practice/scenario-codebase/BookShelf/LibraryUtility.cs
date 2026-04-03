using System;

namespace BridgeLabzTraning.BookShelf
{
    internal sealed class LibraryUtility : ILibraryActions
    {
        private BookNode? head = null;

        // ADD BOOK
        public void AddBook()
        {
            Console.Write("Genre: ");
            string genre = Console.ReadLine()!;

            Console.Write("Title: ");
            string title = Console.ReadLine()!;

            Console.Write("Author: ");
            string author = Console.ReadLine()!;

            // Duplicate check
            BookNode? temp = head;
            while (temp != null)
            {
                if (temp.Data.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase) &&
                    temp.Data.GetAuthor().Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine("Duplicate book not allowed.");
                    return;
                }
                temp = temp.Next;
            }

            BookNode newNode = new BookNode(new Book(title, author, genre));

            if (head == null)
            {
                head = newNode;
            }
            else
            {
                temp = head;
                while (temp.Next != null)
                    temp = temp.Next;

                temp.Next = newNode;
            }

            Console.WriteLine("Book added successfully.");
        }

        // BORROW BOOK
        public void BorrowBook()
        {
            Console.Write("Enter book title to borrow: ");
            string title = Console.ReadLine()!;

            if (head == null)
            {
                Console.WriteLine("Library empty.");
                return;
            }

            if (head.Data.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                head = head.Next;
                Console.WriteLine("Book borrowed.");
                return;
            }

            BookNode temp = head;
            while (temp.Next != null &&
                   !temp.Next.Data.GetTitle().Equals(title, StringComparison.OrdinalIgnoreCase))
            {
                temp = temp.Next;
            }

            if (temp.Next == null)
            {
                Console.WriteLine("Book not found.");
            }
            else
            {
                temp.Next = temp.Next.Next;
                Console.WriteLine("Book borrowed.");
            }
        }

        // DISPLAY CATALOG
        public void DisplayCatalog()
        {
            if (head == null)
            {
                Console.WriteLine("Library empty.");
                return;
            }

            BookNode? temp = head;
            while (temp != null)
            {
                Console.WriteLine(temp.Data.GetInfo());
                temp = temp.Next;
            }
        }
    }
}
