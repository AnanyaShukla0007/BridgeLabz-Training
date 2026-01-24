using System;
using System.Diagnostics;

class TaskRunner
{
    public void Run()
    {
        Stopwatch sw = Stopwatch.StartNew();
        System.Threading.Thread.Sleep(300);
        sw.Stop();
        Console.WriteLine("Execution Time: " + sw.ElapsedMilliseconds + " ms");
    }
}

class Program
{
    static void Main()
    {
        new TaskRunner().Run();
    }
}
