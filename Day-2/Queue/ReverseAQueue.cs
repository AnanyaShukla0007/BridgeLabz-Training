using System;
using System.Collections.Generic;

class ReverseAQueue
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        Queue<int> queue = new Queue<int>();

        for (int i = 0; i < n; i++)
        {
            queue.Enqueue(int.Parse(Console.ReadLine()));
        }

        Stack<int> stack = new Stack<int>();

        while (queue.Count > 0)
        {
            stack.Push(queue.Dequeue());
        }

        while (stack.Count > 0)
        {
            queue.Enqueue(stack.Pop());
        }

        foreach (int item in queue)
        {
            Console.Write(item + " ");
        }
    }
}