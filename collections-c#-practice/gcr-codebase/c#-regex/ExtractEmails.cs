using System;
using System.Text.RegularExpressions;

class ExtractEmails
{
    static void Main()
    {
        string text = "Contact support@example.com and info@company.org";
        string pattern = @"\b[\w.-]+@[\w.-]+\.\w+\b";

        MatchCollection matches = Regex.Matches(text, pattern);

        foreach (Match m in matches)
            Console.WriteLine(m.Value);
    }
}
