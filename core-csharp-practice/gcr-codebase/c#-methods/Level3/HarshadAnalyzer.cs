using System;
class HarshadAnalyzer
{
    static int[] GetDigits(int n)
    {
        char[] c = n.ToString().ToCharArray();
        int[] d = new int[c.Length];
        for (int i = 0; i < c.Length; i++) d[i] = c[i] - '0';
        return d;
    }
    static int Sum(int[] d)
    {
        int s = 0;
        foreach (int x in d) s += x;
        return s;
    }
    static bool IsHarshad(int n) => n % Sum(GetDigits(n)) == 0;
    static void Main()
    {
        int number = 21;
        Console.WriteLine("Harshad: " + IsHarshad(number));
    }
}
