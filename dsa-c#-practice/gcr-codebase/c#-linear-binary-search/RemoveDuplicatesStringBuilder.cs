using System;
using System.Text;
using System.Collections.Generic;

class RemoveDuplicates
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        HashSet<char> seen = new HashSet<char>();
        StringBuilder result = new StringBuilder();

        // Add character only if not seen before
        foreach (char c in input)
        {
            if (!seen.Contains(c))
            {
                seen.Add(c);
                result.Append(c);
            }
        }

        Console.WriteLine("Without Duplicates: " + result);
    }
}
