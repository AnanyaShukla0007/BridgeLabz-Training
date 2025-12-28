using System;
class PowerOfNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int power = int.Parse(Console.ReadLine());
        int result = 1;
        for (int i = 1; i <= power; i++)
        {
            result *= number;
        }
        Console.WriteLine(result);
    }
}
