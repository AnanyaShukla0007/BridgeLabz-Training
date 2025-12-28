using System;
class MeanHeight
{
    static void Main()
    {
        double[] heights = new double[11]; // input taken 
        double sum = 0;
        for (int i = 0; i < 11; i++)
        {
            Console.Write($"Enter height of player {i + 1}: ");
            heights[i] = double.Parse(Console.ReadLine());
            sum += heights[i];
        }
        Console.WriteLine("Mean Height = " + (sum / 11)); // output
    }
}
