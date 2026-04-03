using System;
using System.Text.RegularExpressions;

class FindRepeatingWords
{
    static void Main()
    {
        string text = "This is is a repeated repeated word test";
        string pattern = @"\b(\w+)\s+\1\b";

        foreach (Match m in Regex.Matches(text, pattern))
            Console.WriteLine(m.Groups[1].Value);
    }
}
