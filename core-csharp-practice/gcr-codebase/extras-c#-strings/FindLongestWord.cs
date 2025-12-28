using System;

class FindLongestWord
{
    static string LongestWord(string s)
    {
        string word = "", longest = "";

        for (int i = 0; i <= s.Length; i++)
        {
            if (i == s.Length || s[i] == ' ')
            {
                if (word.Length > longest.Length)
                    longest = word;
                word = "";
            }
            else
                word += s[i];
        }
        return longest;
    }

    static void Main()
    {
        Console.Write("Enter sentence: ");
        string s = Console.ReadLine();
        Console.WriteLine("Longest Word: " + LongestWord(s));
    }
}
