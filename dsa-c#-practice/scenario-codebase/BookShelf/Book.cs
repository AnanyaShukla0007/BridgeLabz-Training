namespace BridgeLabzTraning.BookShelf
{
    internal class Book
    {
        private string title;
        private string author;
        private string genre;

        public Book(string title, string author, string genre)
        {
            this.title = title;
            this.author = author;
            this.genre = genre;
        }

        public string GetTitle()
        {
            return title;
        }

        public string GetAuthor()
        {
            return author;
        }

        public string GetGenre()
        {
            return genre;
        }

        public string GetInfo()
        {
            return title + " by " + author + " [" + genre + "]";
        }
    }
}
