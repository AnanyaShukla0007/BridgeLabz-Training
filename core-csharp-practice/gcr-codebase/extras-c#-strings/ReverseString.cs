using System;

class ReverseString
{
    static string Reverse(string s)
    {
        string rev = "";
        for (int i = s.Length - 1; i >= 0; i--)
            rev += s[i];
        return rev;
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();
        Console.WriteLine("Reversed String: " + Reverse(s));
    }
}
