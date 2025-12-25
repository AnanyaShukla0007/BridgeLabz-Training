using System;

class ParkRunCalculator
{
    static double CalculateRounds(double a, double b, double c)
    {
        double perimeter = a + b + c;
        double distance = 5000; // meters
        return distance / perimeter;
    }

    static void Main()
    {
        Console.Write("Enter side 1: ");
        double a = double.Parse(Console.ReadLine());

        Console.Write("Enter side 2: ");
        double b = double.Parse(Console.ReadLine());

        Console.Write("Enter side 3: ");
        double c = double.Parse(Console.ReadLine());

        Console.WriteLine("Rounds needed: " + CalculateRounds(a, b, c));
    }
}
