using System;
class ChocolateDistribution
{
    static int[] Distribute(int chocolates, int children)
    {
        return new int[] { chocolates / children, chocolates % children };
    }
    static void Main()
    {
        Console.Write("Enter chocolates: "); //input
        int chocolates = int.Parse(Console.ReadLine());
        Console.Write("Enter children: ");
        int children = int.Parse(Console.ReadLine());
        int[] result = Distribute(chocolates, children);
        Console.WriteLine($"Each child gets {result[0]}, Remaining {result[1]}"); //output
    }
}
