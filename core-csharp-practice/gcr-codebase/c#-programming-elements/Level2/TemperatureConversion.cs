using System;

class TemperatureConversion{
    public static void Main(string[] args)
    {
        // Input temperature in Celsius
        Console.WriteLine("Enter the temperature in Celsius: ");
        double celsius = Convert.ToDouble(Console.ReadLine());

        // Conversion formula
        double fahrenheit = (celsius * 9 / 5) + 32;

        // Output result
        Console.WriteLine("The "+celsius+ "Celsius is " + fahrenheit + "Fahrenheit");
        
    }
}
