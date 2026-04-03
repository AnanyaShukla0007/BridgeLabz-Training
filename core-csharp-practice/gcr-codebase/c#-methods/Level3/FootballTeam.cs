using System;
class FootballTeam
{
    static int[] GenerateHeights()
    {
        Random random = new Random();
        int[] heights = new int[11];
        for (int i = 0; i < heights.Length; i++)
            heights[i] = random.Next(150, 251);
        return heights;
    }
    static int FindSum(int[] heights)
    {
        int sum = 0;
        foreach (int h in heights) sum += h;
        return sum;
    }
    static double FindMean(int[] heights)
    {
        return (double)FindSum(heights) / heights.Length;
    }
    static int FindShortest(int[] heights)
    {
        int min = heights[0];
        foreach (int h in heights) min = Math.Min(min, h);
        return min;
    }
    static int FindTallest(int[] heights)
    {
        int max = heights[0];
        foreach (int h in heights) max = Math.Max(max, h);
        return max;
    }
    static void Main()
    {
        int[] heights = GenerateHeights();
        Console.WriteLine("Shortest: " + FindShortest(heights));
        Console.WriteLine("Tallest: " + FindTallest(heights));
        Console.WriteLine("Mean Height: " + FindMean(heights));
    }
}
