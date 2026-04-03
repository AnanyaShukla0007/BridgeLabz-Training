using System;
class PalindromeChecker
{
    static bool IsPalindrome(string s)
    {
        int i = 0, j = s.Length - 1;
        while (i < j)
        {
            if (s[i] != s[j])
                return false;
            i++;
            j--;
        }
        return true;
    }
    static void Main()
    {
        Console.Write("Enter string: ");
        string s = Console.ReadLine();
        Console.WriteLine(IsPalindrome(s) ? "Palindrome" : "Not Palindrome");
    }
}
