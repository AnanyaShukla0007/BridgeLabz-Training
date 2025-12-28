using System;
class CalendarDisplay
{
    static void Main()
    {
        DateTime date = new DateTime(2025, 7, 1);
        Console.WriteLine(date.ToString("MMMM yyyy"));
        Console.WriteLine("Su Mo Tu We Th Fr Sa");
        int day = (int)date.DayOfWeek;
        for (int i = 0; i < day; i++) Console.Write("   ");
        int days = DateTime.DaysInMonth(2025, 7);
        for (int d = 1; d <= days; d++)
        {
            Console.Write($"{d,2} ");
            if ((d + day) % 7 == 0) Console.WriteLine();
        }
    }
}
