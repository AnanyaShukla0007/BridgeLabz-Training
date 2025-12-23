using System;
class Calculator{
    static void Main(){
        Console.WriteLine("Enter first number: ");
        double firstnum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondnum = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter operator (+,-,*,/): )")
        string opo=Console.Readline();
        switch(opo){
            case "+":
                Console.WriteLine("Result = " + (first + second));
                break;
            case "-":
                Console.WriteLine("Result = " + (first - second));
                break;
            case "*":
                Console.WriteLine("Result = " + (first * second));
                break;
            case "/":
                Console.WriteLine("Result = " + (first / second));
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        } 
    }
}