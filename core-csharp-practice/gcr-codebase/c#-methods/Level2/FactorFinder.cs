using System;
class FactorFinder
{
    static int[] FindFactors(int number)
    {
        int count = 0;
        for (int i = 1; i <= number; i++)
            if (number % i == 0) count++;
        int[] factors = new int[count];
        int index = 0;
        for (int i = 1; i <= number; i++)
            if (number % i == 0)
                factors[index++] = i;
        return factors;
    }
    static int FindSum(int[] factors)
    {
        int sum = 0;
        foreach (int f in factors) sum += f;
        return sum;
    }
    static int FindProduct(int[] factors)
    {
        int product = 1;
        foreach (int f in factors) product *= f;
        return product;
    }
    static double FindSumOfSquares(int[] factors)
    {
        double sum = 0;
        foreach (int f in factors)
            sum += Math.Pow(f, 2);
        return sum;
    }
    static void Main()
    {
        Console.Write("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        int[] factors = FindFactors(number);
        Console.WriteLine("Factors:");
        foreach (int f in factors) Console.Write(f + " ");
        Console.WriteLine("\nSum: " + FindSum(factors));
        Console.WriteLine("Product: " + FindProduct(factors));
        Console.WriteLine("Sum of Squares: " + FindSumOfSquares(factors));
    }
}
