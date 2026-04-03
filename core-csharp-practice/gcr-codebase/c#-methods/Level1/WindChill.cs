using System;
class WindChillCalculator
{
    public static double CalculateWindChill(double temp, double speed)
    {
        return 35.74 + 0.6215 * temp + (0.4275 * temp - 35.75) * Math.Pow(speed, 0.16);
    }
    static void Main()
    {
        Console.Write("Enter Temperature: "); //input
        double temp = double.Parse(Console.ReadLine());
        Console.Write("Enter Wind Speed: "); //input
        double speed = double.Parse(Console.ReadLine());
        Console.WriteLine("Wind Chill: " + CalculateWindChill(temp, speed)); //output
    }
}
