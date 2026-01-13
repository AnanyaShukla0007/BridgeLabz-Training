using System;
using System.Text;

class ConcatenateStrings
{
    static void Main()
    {
        string[] words = { "Fit", "Track", " ", "Fitness", " ", "App" };

        // Initialize StringBuilder
        StringBuilder sb = new StringBuilder();

        // Append instead of using +
        foreach (string word in words)
            sb.Append(word);

        Console.WriteLine("Result: " + sb.ToString());
    }
}
