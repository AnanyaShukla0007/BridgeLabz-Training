using System;
using System.Collections.Generic;

class ReverseQueue
{
    static void Main()
    {
        Queue<int> q = new Queue<int>();
        q.Enqueue(10);
        q.Enqueue(20);
        q.Enqueue(30);

        Stack<int> stack = new Stack<int>();

        // Move queue to stack
        while (q.Count > 0)
            stack.Push(q.Dequeue());

        // Move stack back to queue
        while (stack.Count > 0)
            q.Enqueue(stack.Pop());

        foreach (int x in q)
            Console.Write(x + " ");
    }
}
