using System;
class EuclideanDistance
{
    static double Distance(double x1, double y1, double x2, double y2)
        => Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
    static void Main()
    {
        Console.WriteLine("Distance: " + Distance(2, 3, 5, 7));
    }
}
