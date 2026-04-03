using System;
static class MathUtility
{
    public static long Factorial(int n)
    {
        if (n < 0) return -1;
        long result = 1;
        for (int i = 1; i <= n; i++)
            result *= i;
        return result;
    }
    public static bool IsPrime(int n)
    {
        if (n <= 1) return false;
        for (int i = 2; i * i <= n; i++)
            if (n % i == 0) return false;
        return true;
    }
    public static int GCD(int a, int b)
    {
        a = Math.Abs(a);
        b = Math.Abs(b);
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    public static int Fibonacci(int n)
    {
        if (n < 0) return -1;
        if (n == 0) return 0;
        if (n == 1) return 1;
        int a = 0, b = 1;
        for (int i = 2; i <= n; i++)
        {
            int c = a + b;
            a = b;
            b = c;
        }
        return b;
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Factorial(5): " + MathUtility.Factorial(5));
        Console.WriteLine("Factorial(-3): " + MathUtility.Factorial(-3));
        Console.WriteLine("IsPrime(7): " + MathUtility.IsPrime(7));
        Console.WriteLine("IsPrime(1): " + MathUtility.IsPrime(1));
        Console.WriteLine("GCD(48, 18): " + MathUtility.GCD(48, 18));
        Console.WriteLine("GCD(-12, 6): " + MathUtility.GCD(-12, 6));
        Console.WriteLine("Fibonacci(6): " + MathUtility.Fibonacci(6));
        Console.WriteLine("Fibonacci(-2): " + MathUtility.Fibonacci(-2));
    }
}
