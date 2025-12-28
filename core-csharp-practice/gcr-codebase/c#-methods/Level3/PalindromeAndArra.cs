using System;
classPalindromeAndArra
{
    static int[] Reverse(int[] arr)
    {
        int[] r = (int[])arr.Clone();
        Array.Reverse(r);
        return r;
    }
    static bool AreEqual(int[] a, int[] b)
    {
        if (a.Length != b.Length) return false;
        for (int i = 0; i < a.Length; i++)
            if (a[i] != b[i]) return false;
        return true;
    }
    static void Main()
    {
        int[] digits = { 1, 2, 2, 1 };
        Console.WriteLine("Palindrome: " + AreEqual(digits, Reverse(digits)));
    }
}
