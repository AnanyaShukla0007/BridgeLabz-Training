using System;
class PrimeNumber
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        bool isPrime = true;
        if (number <= 1)
            isPrime = false;
        for (int i = 2; i < number; i++)
        {
            if (number % i == 0)
            {
                isPrime = false;
                break;
            }
        }
        Console.WriteLine(isPrime ? "Prime" : "Not Prime");
    }
}
