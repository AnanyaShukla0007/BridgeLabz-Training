using System;

namespace BridgeLabzTraning.BookBuddy
{
    internal class Book
    {
        private string title;
        private string summary;

        public Book(string title, string summary)
        {
            this.title = title;
            this.summary = summary;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetSummary()
        {
            return summary;
        }
    }
}
