using System;
class Marks1D
{
    static void Main()
    {
        Console.Write("Number of students: "); // input
        int n = int.Parse(Console.ReadLine());
        double[] percent = new double[n];
        string[] grade = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Physics: ");
            double p = double.Parse(Console.ReadLine());
            Console.Write("Chemistry: ");
            double c = double.Parse(Console.ReadLine());
            Console.Write("Maths: ");
            double m = double.Parse(Console.ReadLine());
            if (p < 0 || c < 0 || m < 0) { i--; continue; }
            percent[i] = (p + c + m) / 3;
            grade[i] = percent[i] >= 90 ? "A" :
                       percent[i] >= 75 ? "B" :
                       percent[i] >= 60 ? "C" : "D";
        }
        for (int i = 0; i < n; i++)
            Console.WriteLine($"{percent[i]}% Grade {grade[i]}"); // output
    }
}
