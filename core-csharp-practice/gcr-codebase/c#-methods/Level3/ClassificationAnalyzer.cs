using System;
class ClassificationAnalyzer
{
    static int[] GetFactors(int n)
    {
        int count = 0;
        for (int i = 1; i <= n; i++) if (n % i == 0) count++;
        int[] f = new int[count];
        int idx = 0;
        for (int i = 1; i <= n; i++) if (n % i == 0) f[idx++] = i;
        return f;
    }
    static bool IsPerfect(int n)
    {
        int sum = 0;
        foreach (int x in GetFactors(n))
            if (x != n) sum += x;
        return sum == n;
    }
    static void Main()
    {
        Console.WriteLine("Perfect: " + IsPerfect(28));
    }
}
