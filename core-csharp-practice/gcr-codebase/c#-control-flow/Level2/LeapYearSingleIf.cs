using System;
class LeapYear
{
    static void Main()
    {
        int year = int.Parse(Console.ReadLine());

        if (year >= 1582 && (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))){
            Console.WriteLine("Leap Year");
        }
        else{
            Console.WriteLine("Not a Leap Year");
        }
    }
}
