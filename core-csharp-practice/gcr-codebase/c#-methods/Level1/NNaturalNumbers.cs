using System;
class NNaturalNumbers
{
    static int FindSum(int n)
    {
        int sum = 0;
        for (int i = 1; i <= n; i++)
            sum += i;
        return sum;
    }
    static void Main()
    {
        Console.Write("Enter N: "); //input
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine("Sum: " + FindSum(n)); //output 
    }
}
