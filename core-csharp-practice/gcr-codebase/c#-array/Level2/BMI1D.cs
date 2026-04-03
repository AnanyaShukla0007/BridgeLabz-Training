using System;
class BMI1D
{
    static void Main()
    {
        Console.Write("Number of persons: "); // INPUT
        int n = int.Parse(Console.ReadLine());
        double[] w = new double[n];
        double[] h = new double[n];
        double[] bmi = new double[n];
        string[] status = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Weight (kg): ");
            w[i] = double.Parse(Console.ReadLine());
            Console.Write("Height (m): ");
            h[i] = double.Parse(Console.ReadLine());
            bmi[i] = w[i] / (h[i] * h[i]);
            status[i] = bmi[i] < 18.5 ? "Underweight" :
                        bmi[i] < 25 ? "Normal" :
                        bmi[i] < 30 ? "Overweight" : "Obese";
        }
        for (int i = 0; i < n; i++)
            Console.WriteLine($"{w[i]} {h[i]} {bmi[i]} {status[i]}"); // OUTPUT
    }
}
