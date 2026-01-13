using System;

class SearchWord
{
    static void Main()
    {
        string[] sentences =
        {
            "I love coding",
            "C# is powerful",
            "Learning data structures"
        };

        string word = "powerful";

        // Check each sentence
        foreach (string s in sentences)
        {
            if (s.Contains(word))
            {
                Console.WriteLine("Found in sentence: " + s);
                return;
            }
        }

        Console.WriteLine("Word not found");
    }
}
