using System;

class BasicCalculator
{
    static double Add(double a, double b) => a + b;
    static double Subtract(double a, double b) => a - b;
    static double Multiply(double a, double b) => a * b;
    static double Divide(double a, double b) => a / b;

    static void Main()
    {
        Console.Write("Enter two numbers: ");
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());

        Console.Write("Choose operation (+ - * /): ");
        char op = char.Parse(Console.ReadLine());

        double result = 0;

        switch (op)
        {
            case '+': result = Add(a, b); break;
            case '-': result = Subtract(a, b); break;
            case '*': result = Multiply(a, b); break;
            case '/': result = Divide(a, b); break;
        }

        Console.WriteLine("Result: " + result);
    }
}
