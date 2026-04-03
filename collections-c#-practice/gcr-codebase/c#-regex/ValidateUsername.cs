using System;
using System.Text.RegularExpressions;

class ValidateUsername
{
    static void Main()
    {
        string username = "user_123";

        // Starts with letter, allows letters/numbers/_, length 5–15
        string pattern = @"^[A-Za-z][A-Za-z0-9_]{4,14}$";

        if (Regex.IsMatch(username, pattern))
            Console.WriteLine("Valid Username");
        else
            Console.WriteLine("Invalid Username");
    }
}
