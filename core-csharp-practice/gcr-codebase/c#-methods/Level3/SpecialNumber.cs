using System;
class SpecialNumber
{
    static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i <= Math.Sqrt(n); i++)
            if (n % i == 0) return false;
        return true;
    }
    static bool IsBuzz(int n) => n % 7 == 0 || n % 10 == 7;
    static void Main()
    {
        int n = 7;
        Console.WriteLine("Prime: " + IsPrime(n));
        Console.WriteLine("Buzz: " + IsBuzz(n));
    }
}
