using System;
using System.Collections.Generic;

class RotateList
{
    static void Main()
    {
        List<int> list = new List<int> { 10, 20, 30, 40, 50 };
        int k = 2;

        // Normalize rotation count
        k = k % list.Count;

        List<int> rotated = new List<int>();

        // Add from k to end
        for (int i = k; i < list.Count; i++)
            rotated.Add(list[i]);

        // Add from start to k
        for (int i = 0; i < k; i++)
            rotated.Add(list[i]);

        Console.WriteLine("Rotated List:");
        foreach (int x in rotated) Console.Write(x + " ");
    }
}
