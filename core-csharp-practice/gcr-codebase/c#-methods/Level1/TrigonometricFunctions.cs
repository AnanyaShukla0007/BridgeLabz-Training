using System;
using System.IO.Compression;

class Trigonometry
{
    public double[] calculateTrigonometricFunctions(double angle)
    {
        double val = angle * 3.14 / 100; //conversion to radian
        double sin = Math.Sin(val);
        double cos = Math.Cos(val);
        double tan = Math.Tan(val);
        return new double[] { sin, cos, tan };
    }
    public static void Main()
    {
        //taking Input
        double angle = double.Parse(Console.ReadLine());
        //calling method
        int[] arr = calculateTrigonometricFunctions(angle);
        Console.WriteLine("The sin is " + arr[0] + "the cos is " + arr[1] + "the tan value is " + arr[2]);
    }
}