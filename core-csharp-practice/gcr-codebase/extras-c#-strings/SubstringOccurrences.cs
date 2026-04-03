using System;

class SubstringOccurrences
{
    static int CountOccurrences(string text, string sub)
    {
        int count = 0;

        for (int i = 0; i <= text.Length - sub.Length; i++)
        {
            int j;
            for (j = 0; j < sub.Length; j++)
                if (text[i + j] != sub[j])
                    break;

            if (j == sub.Length)
                count++;
        }
        return count;
    }

    static void Main()
    {
        Console.Write("Enter main string: ");
        string text = Console.ReadLine();

        Console.Write("Enter substring: ");
        string sub = Console.ReadLine();

        Console.WriteLine("Occurrences: " + CountOccurrences(text, sub));
    }
}
