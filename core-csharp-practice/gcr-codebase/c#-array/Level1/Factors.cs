using System;
class Factors
{
    static void Main()
    {
        Console.Write("Enter number: "); // input
        int number = int.Parse(Console.ReadLine());
        int max = 10, index = 0;
        int[] factors = new int[max];
        for (int i = 1; i <= number; i++)
        {
            if (number % i == 0)
            {
                if (index == max)
                {
                    max *= 2;
                    int[] temp = new int[max];
                    Array.Copy(factors, temp, index);
                    factors = temp;
                }
                factors[index++] = i;
            }
        }
        Console.WriteLine("Factors:");
        for (int i = 0; i < index; i++)
            Console.Write(factors[i] + " "); // output
    }
}
