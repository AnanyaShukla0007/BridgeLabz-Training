using System;

namespace BridgeLabzTraning.BookBuddy
{
    internal class Author
    {
        private string name;
        private string nationality;

        public Author(string name, string nationality)
        {
            this.name = name;
            this.nationality = nationality;
        }

        public string GetName()
        {
            return name;
        }

        public string GetAuthorDetails()
        {
            return name + " (" + nationality + ")";
        }
    }
}
