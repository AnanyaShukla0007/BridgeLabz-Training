using System;

class CompareStringsLexicographically
{
    static void Compare(string s1, string s2)
    {
        int len = Math.Min(s1.Length, s2.Length);

        for (int i = 0; i < len; i++)
        {
            if (s1[i] < s2[i])
            {
                Console.WriteLine($"\"{s1}\" comes before \"{s2}\"");
                return;
            }
            else if (s1[i] > s2[i])
            {
                Console.WriteLine($"\"{s2}\" comes before \"{s1}\"");
                return;
            }
        }

        if (s1.Length == s2.Length)
            Console.WriteLine("Both strings are equal");
        else if (s1.Length < s2.Length)
            Console.WriteLine($"\"{s1}\" comes before \"{s2}\"");
        else
            Console.WriteLine($"\"{s2}\" comes before \"{s1}\"");
    }

    static void Main()
    {
        Console.Write("Enter first string: ");
        string s1 = Console.ReadLine();

        Console.Write("Enter second string: ");
        string s2 = Console.ReadLine();

        Compare(s1, s2);
    }
}
