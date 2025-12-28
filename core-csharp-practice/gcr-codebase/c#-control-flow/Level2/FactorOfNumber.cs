using System;
class FactorOfNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());        for (int i = 1; i < number; i++)
        {
            if (number % i == 0)
                Console.WriteLine(i);
        }
    }
}
