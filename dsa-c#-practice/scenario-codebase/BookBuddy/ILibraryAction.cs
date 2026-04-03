using System;

namespace BridgeLabzTraning.BookBuddy
{
    internal interface ILibraryAction
    {
        void AddBook(string title, string author);
        void SortBooksAlphabetically();
        void SearchByAuthor(string author);
    }
}
