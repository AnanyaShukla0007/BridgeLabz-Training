using System;
using System.Text.RegularExpressions;

class ValidateIPAddress
{
    static void Main()
    {
        string ip = "192.168.1.1";

        string pattern =
            @"^((25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)\.){3}
              (25[0-5]|2[0-4]\d|1\d\d|[1-9]?\d)$";

        Console.WriteLine(Regex.IsMatch(ip, pattern)
            ? "Valid IP"
            : "Invalid IP");
    }
}
