using System;
class QuotientandRemainder
{
    public static int[] FindRemainderAndQuotient(int number, int divisor)
    {
        return new int[] { number / divisor, number % divisor };
    }
    static void Main()
    {
        Console.Write("Enter number: "); //input
        int number = int.Parse(Console.ReadLine());
        Console.Write("Enter divisor: ");
        int divisor = int.Parse(Console.ReadLine());
        int[] result = FindRemainderAndQuotient(number, divisor);
        Console.WriteLine($"Quotient: {result[0]}, Remainder: {result[1]}"); //output
    }
}
