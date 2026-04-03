using System;

class BookNode
{
    public int Id;
    public string Title, Author;
    public bool Available;
    public BookNode Prev, Next;
}

class Library
{
    BookNode head, tail;

    public void Add(int id, string t, string a)
    {
        BookNode n = new BookNode { Id = id, Title = t, Author = a, Available = true };
        if (head == null) head = tail = n;
        else { tail.Next = n; n.Prev = tail; tail = n; }
    }

    public void Display()
    {
        for (BookNode t = head; t != null; t = t.Next)
            Console.WriteLine($"{t.Title} {t.Author} {t.Available}");
    }
}
