using System;
class SumofDigits
{
    static int RecursiveSum(int n)
    {
        if (n == 0) return 0;
        return n + RecursiveSum(n - 1);
    }
    static int FormulaSum(int n)
    {
        return n * (n + 1) / 2;
    }
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine());
        if (n <= 0) return;
        int recursiveResult = RecursiveSum(n);
        int formulaResult = FormulaSum(n);
        Console.WriteLine($"Recursive: {recursiveResult}");
        Console.WriteLine($"Formula: {formulaResult}");
        Console.WriteLine(recursiveResult == formulaResult ? "Results Match" : "Mismatch");
    }
}
