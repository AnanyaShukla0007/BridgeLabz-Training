using System;

class RemoveDuplicateCharacters
{
    static string RemoveDuplicates(string s)
    {
        string result = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (!result.Contains(s[i].ToString()))
                result += s[i];
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();
        Console.WriteLine("After Removing Duplicates: " + RemoveDuplicates(s));
    }
}
