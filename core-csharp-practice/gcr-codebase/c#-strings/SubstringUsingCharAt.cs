using System;
class SubstringUsingCharAt
{
    static string ManualSubstring(string s, int start, int end)
    {
        string result = "";
        for (int i = start; i < end; i++) //looping
        {
            result += s[i];
        }
        return result; //return
    }
    static void Main()
    {
        Console.Write("Enter string: "); //input string
        string s = Console.ReadLine(); 
        Console.Write("Enter start index: "); //input starting index
        int start = int.Parse(Console.ReadLine());
        Console.Write("Enter end index: "); //input ending index
        int end = int.Parse(Console.ReadLine());
        Console.WriteLine("Manual Substring: " + ManualSubstring(s, start, end)); //output manual
        Console.WriteLine("Built-in Substring: " + s.Substring(start, end - start)); //output builtin
    }
}
