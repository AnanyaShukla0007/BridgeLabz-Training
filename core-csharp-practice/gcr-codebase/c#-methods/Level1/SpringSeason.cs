using System;
class SpringSeason
{
    static bool IsSpring(int month, int day)
    {
        return (month == 3 && day >= 20) ||
               (month > 3 && month < 6) ||
               (month == 6 && day <= 20);
    }
    static void Main(string[] args)
    {
        int month = int.Parse(args[0]);
        int day = int.Parse(args[1]);
        Console.WriteLine(IsSpring(month, day) ? "Its a Spring Season" : "Not a Spring Season"); //output
    }
}
