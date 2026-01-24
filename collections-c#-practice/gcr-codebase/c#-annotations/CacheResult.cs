using System;
using System.Collections.Generic;

class Calculator
{
    Dictionary<int, int> cache = new Dictionary<int, int>();

    public int Square(int n)
    {
        if (cache.ContainsKey(n))
            return cache[n];

        Console.WriteLine("Computing...");
        int result = n * n;
        cache[n] = result;
        return result;
    }
}

class Program
{
    static void Main()
    {
        Calculator c = new Calculator();
        Console.WriteLine(c.Square(5));
        Console.WriteLine(c.Square(5)); // Cached
    }
}
