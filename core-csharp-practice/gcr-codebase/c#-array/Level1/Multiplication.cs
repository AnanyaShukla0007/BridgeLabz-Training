using System;
class Multiplication
{
    static void Main()
    {
        Console.Write("Enter number: "); 
        int number = int.Parse(Console.ReadLine()); //input
        int[] table = new int[10];
        for (int i = 1; i <= 10; i++)
        {
            table[i - 1] = number * i;
            Console.WriteLine($"{number} * {i} = {table[i - 1]}"); //output
        }
    }
}
