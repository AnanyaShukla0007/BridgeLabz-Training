using System;
class BMI2D
{
    static void Main()
    {
        Console.Write("Number of persons: "); //INPUT
        int n = int.Parse(Console.ReadLine());
        double[][] data = new double[n][];
        string[] status = new string[n];
        for (int i = 0; i < n; i++)
        {
            data[i] = new double[3];
            Console.Write("Weight: ");
            data[i][0] = double.Parse(Console.ReadLine());
            Console.Write("Height: ");
            data[i][1] = double.Parse(Console.ReadLine());
            data[i][2] = data[i][0] / (data[i][1] * data[i][1]);
            status[i] = data[i][2] < 18.5 ? "Underweight" :
                        data[i][2] < 25 ? "Normal" :
                        data[i][2] < 30 ? "Overweight" : "Obese";
        }
        for (int i = 0; i < n; i++)
            Console.WriteLine($"{data[i][0]} {data[i][1]} {data[i][2]} {status[i]}"); //OUTPUT
    }
}
