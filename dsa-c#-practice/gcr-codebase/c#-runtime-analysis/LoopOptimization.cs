using System;
using System.Diagnostics;
using System.Collections.Generic;

class LoopOptimization
{
    static void Main()
    {
        List<int> list = new List<int>();
        for (int i = 0; i < 1_000_000; i++) list.Add(i);

        Stopwatch sw = new Stopwatch();

        // for loop
        sw.Start();
        for (int i = 0; i < list.Count; i++)
        {
            int x = list[i];
        }
        sw.Stop();
        Console.WriteLine("for loop time: " + sw.ElapsedMilliseconds + " ms");

        // foreach loop
        sw.Restart();
        foreach (int x in list)
        {
            int y = x;
        }
        sw.Stop();
        Console.WriteLine("foreach loop time: " + sw.ElapsedMilliseconds + " ms");
    }
}
