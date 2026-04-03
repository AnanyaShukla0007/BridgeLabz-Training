using System;
class FizzBuzz
{
    static void Main()
    {
        Console.Write("Enter number: ");
        int n = int.Parse(Console.ReadLine());
        string[] result = new string[n + 1];
        for (int i = 1; i <= n; i++)
        {
            if (i % 3 == 0 && i % 5 == 0) result[i] = "FizzBuzz";
            else if (i % 3 == 0) result[i] = "Fizz";
            else if (i % 5 == 0) result[i] = "Buzz";
            else result[i] = i.ToString();
        }
        for (int i = 1; i <= n; i++)
            Console.WriteLine($"Position {i} = {result[i]}");
    }
}
