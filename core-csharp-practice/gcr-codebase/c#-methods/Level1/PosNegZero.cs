using System;
class PosNegZero
{
    static int CheckNumber(int number)
    {
        if (number > 0) return 1;
        if (number < 0) return -1;
        return 0;
    }
    static void Main()
    {
        Console.Write("Enter number: "); //input
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Result: " + CheckNumber(number)); //output
    }
}
