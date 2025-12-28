using System;

class ToggleCase
{
    static string Toggle(string s)
    {
        string result = "";

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] >= 'A' && s[i] <= 'Z')
                result += (char)(s[i] + 32);
            else if (s[i] >= 'a' && s[i] <= 'z')
                result += (char)(s[i] - 32);
            else
                result += s[i];
        }
        return result;
    }

    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();
        Console.WriteLine("Toggled Case: " + Toggle(s));
    }
}
