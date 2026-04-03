using System;
using System.Text.RegularExpressions;

class ExtractCurrency
{
    static void Main()
    {
        string text = "Price is $45.99 and discount is $ 10.50";
        string pattern = @"\$?\s?\d+(\.\d{2})";

        foreach (Match m in Regex.Matches(text, pattern))
            Console.WriteLine(m.Value.Trim());
    }
}
