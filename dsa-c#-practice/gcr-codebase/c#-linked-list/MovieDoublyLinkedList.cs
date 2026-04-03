using System;

class MovieNode
{
    public string Title, Director;
    public int Year;
    public double Rating;
    public MovieNode Prev, Next;

    public MovieNode(string t, string d, int y, double r)
    {
        Title = t; Director = d; Year = y; Rating = r;
    }
}

class MovieList
{
    MovieNode head, tail;

    public void AddLast(string t, string d, int y, double r)
    {
        MovieNode n = new MovieNode(t, d, y, r);
        if (head == null) head = tail = n;
        else { tail.Next = n; n.Prev = tail; tail = n; }
    }

    public void Remove(string title)
    {
        MovieNode t = head;
        while (t != null && t.Title != title) t = t.Next;
        if (t == null) return;
        if (t == head) head = t.Next;
        if (t == tail) tail = t.Prev;
        if (t.Prev != null) t.Prev.Next = t.Next;
        if (t.Next != null) t.Next.Prev = t.Prev;
    }

    public void DisplayForward()
    {
        for (MovieNode t = head; t != null; t = t.Next)
            Console.WriteLine($"{t.Title} {t.Director} {t.Rating}");
    }

    public void DisplayReverse()
    {
        for (MovieNode t = tail; t != null; t = t.Prev)
            Console.WriteLine($"{t.Title} {t.Director} {t.Rating}");
    }
}

class Program
{
    static void Main()
    {
        MovieList m = new MovieList();
        m.AddLast("Inception", "Nolan", 2010, 9.0);
        m.DisplayForward();
    }
}
