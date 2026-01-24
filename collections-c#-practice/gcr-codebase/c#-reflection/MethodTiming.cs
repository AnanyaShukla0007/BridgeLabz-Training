using System;
using System.Diagnostics;
using System.Reflection;

class TestClass
{
    public void Task()
    {
        System.Threading.Thread.Sleep(500);
    }
}

class MethodTiming
{
    static void Main()
    {
        TestClass obj = new TestClass();
        MethodInfo method = typeof(TestClass).GetMethod("Task");

        Stopwatch sw = Stopwatch.StartNew();
        method.Invoke(obj, null);
        sw.Stop();

        Console.WriteLine("Execution Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
