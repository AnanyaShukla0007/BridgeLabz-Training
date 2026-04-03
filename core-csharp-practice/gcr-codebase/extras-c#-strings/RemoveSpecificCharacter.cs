using System;

class RemoveSpecificCharacter
{
    static string RemoveChar(string s, char ch)
    {
        string result = "";
        for (int i = 0; i < s.Length; i++)
            if (s[i] != ch)
                result += s[i];
        return result;
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();

        Console.Write("Enter character to remove: ");
        char ch = char.Parse(Console.ReadLine());

        Console.WriteLine("Modified String: " + RemoveChar(s, ch));
    }
}
