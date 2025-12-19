using System;
class DivideChocolate
{
    static void Main()
    {
        Console.Write("Enter number of chocolates: ");
        int numberOfChocolates = int.Parse(Console.ReadLine());
        Console.Write("Enter number of children: ");
        int numberOfChildren = int.Parse(Console.ReadLine());
        int eachChildGets = numberOfChocolates / numberOfChildren;
        int remaining = numberOfChocolates % numberOfChildren;
        Console.WriteLine($"The number of chocolates each child gets is {eachChildGets} and the number of remaining chocolates is {remaining}");
    }
}
