using System;
using System.Diagnostics;

class FibonacciComparison
{
    static int FibonacciRecursive(int n)
    {
        if (n <= 1) return n;
        return FibonacciRecursive(n - 1) + FibonacciRecursive(n - 2);
    }

    static int FibonacciIterative(int n)
    {
        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int sum = a + b;
            a = b;
            b = sum;
        }
        return b;
    }

    static void Main()
    {
        Stopwatch sw = new Stopwatch();

        sw.Start();
        FibonacciRecursive(30);
        sw.Stop();
        Console.WriteLine("Recursive Fibonacci Time: " + sw.ElapsedMilliseconds + " ms");

        sw.Restart();
        FibonacciIterative(30);
        sw.Stop();
        Console.WriteLine("Iterative Fibonacci Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
