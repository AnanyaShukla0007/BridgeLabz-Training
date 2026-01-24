using System;
using System.Text.RegularExpressions;

class ValidateCreditCard
{
    static void Main()
    {
        string card = "4123456789012345";

        string visaPattern = @"^4\d{15}$";
        string masterPattern = @"^5\d{15}$";

        if (Regex.IsMatch(card, visaPattern))
            Console.WriteLine("Visa Card");
        else if (Regex.IsMatch(card, masterPattern))
            Console.WriteLine("MasterCard");
        else
            Console.WriteLine("Invalid Card");
    }
}
