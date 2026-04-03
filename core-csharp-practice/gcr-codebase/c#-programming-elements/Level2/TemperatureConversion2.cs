using System;

class TemperatureConversion2{
    public static void Main(string[] args)
    {
        // Input temperature in fahrenheit
        Console.WriteLine("Enter the temperature in fahrenheit: ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // Conversion formula
        double celsius = (fahrenheit-32) * 5/9;

        // Output result
        Console.WriteLine("The "+fahrenheit+ "Fahrenheit is " + celsius + "Celsius");
        
    }
}
