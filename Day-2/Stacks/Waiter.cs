using System;
using System.Collections.Generic;

class Waiter
{
    static List<int> GeneratePrimes(int q)
    {
        List<int> primes = new List<int>();
        int num = 2;

        while (primes.Count < q)
        {
            bool isPrime = true;

            for (int i = 2; i * i <= num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
                primes.Add(num);

            num++;
        }

        return primes;
    }

    static void Main()
    {
        string[] input = Console.ReadLine().Split();
        int n = int.Parse(input[0]);
        int q = int.Parse(input[1]);

        string[] arr = Console.ReadLine().Split();

        Stack<int> A = new Stack<int>();

        for (int i = 0; i < n; i++)
        {
            A.Push(int.Parse(arr[i]));
        }

        List<int> primes = GeneratePrimes(q);

        for (int i = 0; i < q; i++)
        {
            Stack<int> nextA = new Stack<int>();
            Stack<int> B = new Stack<int>();

            while (A.Count > 0)
            {
                int plate = A.Pop();

                if (plate % primes[i] == 0)
                    B.Push(plate);
                else
                    nextA.Push(plate);
            }

            while (B.Count > 0)
            {
                Console.WriteLine(B.Pop());
            }

            A = nextA;
        }

        while (A.Count > 0)
        {
            Console.WriteLine(A.Pop());
        }
    }
}