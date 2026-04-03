using System;
using System.Collections.Generic;

class NthFromEnd
{
    static void Main()
    {
        LinkedList<string> list = new LinkedList<string>(
            new string[] { "A", "B", "C", "D", "E" });

        int n = 2;

        var fast = list.First;
        var slow = list.First;

        // Move fast pointer n steps ahead
        for (int i = 0; i < n; i++)
            fast = fast.Next;

        // Move both pointers together
        while (fast != null)
        {
            fast = fast.Next;
            slow = slow.Next;
        }

        Console.WriteLine("Nth from end: " + slow.Value);
    }
}
