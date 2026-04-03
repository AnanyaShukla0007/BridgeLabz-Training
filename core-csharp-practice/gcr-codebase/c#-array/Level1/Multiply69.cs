using System;
class Multiply69
{
    static void Main()
    {
        Console.Write("Enter number: "); //input
        int number = int.Parse(Console.ReadLine());
        int[] result = new int[4];
        for (int i = 6; i <= 9; i++)
        {
            result[i - 6] = number * i;
            Console.WriteLine($"{number} * {i} = {result[i - 6]}"); // output
        }
    }
}
