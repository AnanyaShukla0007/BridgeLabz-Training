using System;
using System.Text.RegularExpressions;

class CensorBadWords
{
    static void Main()
    {
        string text = "This is a damn bad example with stupid words";
        string pattern = @"\b(damn|stupid)\b";

        string result = Regex.Replace(text, pattern, "****",
            RegexOptions.IgnoreCase);

        Console.WriteLine(result);
    }
}
