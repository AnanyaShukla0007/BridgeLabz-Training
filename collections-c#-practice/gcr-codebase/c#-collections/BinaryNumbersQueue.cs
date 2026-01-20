using System;
using System.Collections.Generic;

class BinaryNumbers
{
    static void Main()
    {
        int n = 5;
        Queue<string> q = new Queue<string>();
        q.Enqueue("1");

        for (int i = 0; i < n; i++)
        {
            string current = q.Dequeue();
            Console.Write(current + " ");

            q.Enqueue(current + "0");
            q.Enqueue(current + "1");
        }
    }
}
