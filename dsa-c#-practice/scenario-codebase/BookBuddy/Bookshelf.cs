using System;
using System.Collections.Generic;

namespace BridgeLabzTraning.BookBuddy
{
    internal class Bookshelf : AbstractBookshelf, ILibraryAction
    {
        public void AddBook(string title, string author)
        {
            books.Add(title + " - " + author);
            Console.WriteLine("Book added successfully.");
        }

        public void SortBooksAlphabetically()
        {
            books.Sort();
            Console.WriteLine("Books sorted alphabetically.");
        }

        public void SearchByAuthor(string author)
        {
            bool found = false;

            foreach (string book in books)
            {
                string[] parts = book.Split('-');
                if (parts[1].Trim().Equals(author, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(book);
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No books found for this author.");
        }

        public void ExportBooks()
        {
            string[] exported = ExportToArray();
            Console.WriteLine("Exported Books:");
            foreach (string b in exported)
                Console.WriteLine(b);
        }
    }
}
