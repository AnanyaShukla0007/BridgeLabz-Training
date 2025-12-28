using System;
class ScorecardGenerator
{
    static void Main()
    {
        Random r = new Random();
        for (int i = 1; i <= 3; i++)
        {
            int p = r.Next(50, 100);
            int c = r.Next(50, 100);
            int m = r.Next(50, 100);
            int total = p + c + m;
            Console.WriteLine($"Total: {total}, Avg: {total/3.0}");
        }
    }
}
