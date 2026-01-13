using System;

namespace BridgeLabzTraning.BookBuddy
{
    internal sealed class BookUtility : IBookActions
    {
        private Book[] books = new Book[50];
        private Author[] authors = new Author[50];
        private int count = 0;

        public void AddBook()
        {
            Console.Write("Book Title: ");
            string title = Console.ReadLine();

            Console.Write("Summary: ");
            string summary = Console.ReadLine();

            Console.Write("Author Name: ");
            string authorName = Console.ReadLine();

            Console.Write("Author Nationality: ");
            string nationality = Console.ReadLine();

            books[count] = new Book(title, summary);
            authors[count] = new Author(authorName, nationality);
            count++;

            Console.WriteLine("Book added successfully.");
        }

        public void SearchByAuthor()
        {
            Console.Write("Enter author name: ");
            string search = Console.ReadLine();

            bool found = false;

            for (int i = 0; i < count; i++)
            {
                if (authors[i].GetName()
                    .Equals(search, StringComparison.OrdinalIgnoreCase))
                {
                    Console.WriteLine(
                        books[i].GetTitle() + " by " +
                        authors[i].GetAuthorDetails());
                    found = true;
                }
            }

            if (!found)
                Console.WriteLine("No books found for this author.");
        }

        public void SortBooks()
        {
            for (int i = 0; i < count - 1; i++)
            {
                for (int j = i + 1; j < count; j++)
                {
                    if (string.Compare(
                        books[i].GetTitle(),
                        books[j].GetTitle(),
                        true) > 0)
                    {
                        Book tempBook = books[i];
                        books[i] = books[j];
                        books[j] = tempBook;

                        Author tempAuthor = authors[i];
                        authors[i] = authors[j];
                        authors[j] = tempAuthor;
                    }
                }
            }
            Console.WriteLine("Books sorted alphabetically.");
        }

        public void ExportBooks()
        {
            Book[] exportBooks = new Book[count];
            Array.Copy(books, exportBooks, count);

            Console.WriteLine("Exported Books:");
            for (int i = 0; i < exportBooks.Length; i++)
            {
                Console.WriteLine(
                    exportBooks[i].GetTitle() + " by " +
                    authors[i].GetAuthorDetails());
            }
        }
    }
}
