using System;

class ItemNode
{
    public int Id, Qty;
    public string Name;
    public double Price;
    public ItemNode Next;

    public ItemNode(int i, string n, int q, double p)
    {
        Id = i; Name = n; Qty = q; Price = p;
    }
}

class Inventory
{
    ItemNode head;

    public void Add(int i, string n, int q, double p)
    {
        ItemNode node = new ItemNode(i, n, q, p);
        node.Next = head;
        head = node;
    }

    public double TotalValue()
    {
        double sum = 0;
        for (ItemNode t = head; t != null; t = t.Next)
            sum += t.Price * t.Qty;
        return sum;
    }
}

class Program
{
    static void Main()
    {
        Inventory i = new Inventory();
        i.Add(1, "Mouse", 5, 500);
        Console.WriteLine(i.TotalValue());
    }
}
