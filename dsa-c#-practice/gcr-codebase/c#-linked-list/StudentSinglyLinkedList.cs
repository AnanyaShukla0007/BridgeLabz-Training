using System;

class StudentNode
{
    public int Roll;
    public string Name;
    public int Age;
    public string Grade;
    public StudentNode Next;

    public StudentNode(int r, string n, int a, string g)
    {
        Roll = r; Name = n; Age = a; Grade = g; Next = null;
    }
}

class StudentList
{
    StudentNode head;

    public void AddFirst(int r, string n, int a, string g)
    {
        StudentNode node = new StudentNode(r, n, a, g);
        node.Next = head;
        head = node;
    }

    public void AddLast(int r, string n, int a, string g)
    {
        StudentNode node = new StudentNode(r, n, a, g);
        if (head == null) { head = node; return; }
        StudentNode temp = head;
        while (temp.Next != null) temp = temp.Next;
        temp.Next = node;
    }

    public void Delete(int roll)
    {
        if (head == null) return;
        if (head.Roll == roll) { head = head.Next; return; }
        StudentNode t = head;
        while (t.Next != null && t.Next.Roll != roll) t = t.Next;
        if (t.Next != null) t.Next = t.Next.Next;
    }

    public void Search(int roll)
    {
        StudentNode t = head;
        while (t != null)
        {
            if (t.Roll == roll)
            {
                Console.WriteLine($"{t.Roll} {t.Name} {t.Age} {t.Grade}");
                return;
            }
            t = t.Next;
        }
        Console.WriteLine("Not Found");
    }

    public void UpdateGrade(int roll, string grade)
    {
        StudentNode t = head;
        while (t != null)
        {
            if (t.Roll == roll) { t.Grade = grade; return; }
            t = t.Next;
        }
    }

    public void Display()
    {
        StudentNode t = head;
        while (t != null)
        {
            Console.WriteLine($"{t.Roll} {t.Name} {t.Age} {t.Grade}");
            t = t.Next;
        }
    }
}

class Program
{
    static void Main()
    {
        StudentList s = new StudentList();
        s.AddFirst(1, "Ana", 21, "A");
        s.AddLast(2, "Ravi", 22, "B");
        s.Display();
    }
}
