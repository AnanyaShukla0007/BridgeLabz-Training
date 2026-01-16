namespace BridgeLabzTraning.BookShelf
{
    internal class BookNode
    {
        public Book Data;
        public BookNode? Next;

        public BookNode(Book book)
        {
            Data = book;
            Next = null;
        }
    }
}
