using System;

class TaskNode
{
    public int Id;
    public string Name;
    public int Priority;
    public TaskNode Next;

    public TaskNode(int i, string n, int p)
    {
        Id = i; Name = n; Priority = p;
    }
}

class TaskList
{
    TaskNode head;

    public void Add(int id, string name, int p)
    {
        TaskNode n = new TaskNode(id, name, p);
        if (head == null)
        {
            head = n; n.Next = head;
            return;
        }
        TaskNode t = head;
        while (t.Next != head) t = t.Next;
        t.Next = n; n.Next = head;
    }

    public void Display()
    {
        if (head == null) return;
        TaskNode t = head;
        do
        {
            Console.WriteLine($"{t.Id} {t.Name} {t.Priority}");
            t = t.Next;
        } while (t != head);
    }
}

class Program
{
    static void Main()
    {
        TaskList t = new TaskList();
        t.Add(1, "Coding", 1);
        t.Add(2, "Testing", 2);
        t.Display();
    }
}
