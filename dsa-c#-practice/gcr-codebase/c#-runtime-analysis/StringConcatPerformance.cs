using System;
using System.Text;
using System.Diagnostics;

class StringConcatPerformance
{
    static void Main()
    {
        int n = 100000;
        Stopwatch sw = new Stopwatch();

        // Using string
        sw.Start();
        string s = "";
        for (int i = 0; i < n; i++)
            s += "A";
        sw.Stop();
        Console.WriteLine("String Time: " + sw.ElapsedMilliseconds + " ms");

        // Using StringBuilder
        sw.Restart();
        StringBuilder sb = new StringBuilder();
        for (int i = 0; i < n; i++)
            sb.Append("A");
        sw.Stop();
        Console.WriteLine("StringBuilder Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
