using System;

class DateArithmetic
{
    static void Main()
    {
        Console.Write("Enter date (yyyy-MM-dd): ");
        DateTime date = DateTime.Parse(Console.ReadLine());

        DateTime result = date
            .AddDays(7)
            .AddMonths(1)
            .AddYears(2)
            .AddDays(-21); // subtract 3 weeks

        Console.WriteLine("Final Date: " + result.ToShortDateString());
    }
}
