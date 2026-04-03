using System;
class Calculator
{
    static void Main()
    {
        Console.WriteLine("Enter first number:");
        double firstnum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number:");
        double secondnum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter operator (+, -, *, /):");
        string op = Console.ReadLine();
        switch (op)
        {
            case "+":
                Console.WriteLine("Result = " + (firstnum + secondnum));
                break;
            case "-":
                Console.WriteLine("Result = " + (firstnum - secondnum));
                break;
            case "*":
                Console.WriteLine("Result = " + (firstnum * secondnum));
                break;
            case "/":
                Console.WriteLine("Result = " + (firstnum / secondnum));
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}