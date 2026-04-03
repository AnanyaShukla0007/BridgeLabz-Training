using System;
using System.Text;
using System.Diagnostics;

class PerformanceTest
{
    static void Main()
    {
        Stopwatch sw = new Stopwatch();

        // Using StringBuilder
        sw.Start();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < 100000; i++)
            sb.Append("A");
        sw.Stop();
        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
