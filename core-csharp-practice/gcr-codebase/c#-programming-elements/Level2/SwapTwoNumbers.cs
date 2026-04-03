using System;
class SwapTwoNumbers{
    static void Main{
        Console.Write("Enter number 1: ");
        int num1=int.Parse(Console.ReadLine());
        Console.Write("Enter number 2: ");
        int num2=int.Parse(Console.ReadLine());
        int num3=num1;
        num1=num2;
        num2=num3;
        Console.WriteLine("The swapped numbers are " + num1 + " and " + num2);
    }
}