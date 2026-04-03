using System;

class TicketNode
{
    public int Id;
    public string Customer, Movie;
    public TicketNode Next;
}

class TicketList
{
    TicketNode head;

    public void Add(int id, string c, string m)
    {
        TicketNode n = new TicketNode { Id = id, Customer = c, Movie = m };
        if (head == null) { head = n; n.Next = head; return; }
        TicketNode t = head;
        while (t.Next != head) t = t.Next;
        t.Next = n; n.Next = head;
    }

    public int Count()
    {
        if (head == null) return 0;
        int count = 0;
        TicketNode t = head;
        do { count++; t = t.Next; } while (t != head);
        return count;
    }
}
