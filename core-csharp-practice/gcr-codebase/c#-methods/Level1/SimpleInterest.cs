using System;
class SimpleInterest
{
    static double CalculateSimpleInterest(double principal, double rate, double time)
    {
        return (principal * rate * time) / 100;
    }
    static void Main()
    {
        Console.Write("Enter Principal: "); //principal amount
        double principal = double.Parse(Console.ReadLine());
        Console.Write("Enter Rate: "); //rate
        double rate = double.Parse(Console.ReadLine());
        Console.Write("Enter Time: "); //time
        double time = double.Parse(Console.ReadLine());
        double interest = CalculateSimpleInterest(principal, rate, time);
        Console.WriteLine($"The Simple Interest is {interest} for Principal {principal}, Rate {rate}, Time {time}"); //output
    }
}
