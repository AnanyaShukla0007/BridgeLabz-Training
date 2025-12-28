using System;

class TemperatureConverter
{
    static double CelsiusToFahrenheit(double c)
    {
        return (c * 9 / 5) + 32;
    }

    static double FahrenheitToCelsius(double f)
    {
        return (f - 32) * 5 / 9;
    }

    static void Main()
    {
        Console.Write("Enter temperature: ");
        double temp = double.Parse(Console.ReadLine());

        Console.Write("Convert to (C/F): ");
        char choice = char.Parse(Console.ReadLine());

        if (choice == 'C')
            Console.WriteLine("Celsius: " + FahrenheitToCelsius(temp));
        else
            Console.WriteLine("Fahrenheit: " + CelsiusToFahrenheit(temp));
    }
}
