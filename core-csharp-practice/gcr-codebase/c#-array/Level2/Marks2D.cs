using System;
class Marks2D
{
    static void Main()
    {
        Console.Write("Number of students: "); // input
        int n = int.Parse(Console.ReadLine());
        double[,] marks = new double[n, 3];
        double[] percent = new double[n];
        string[] grade = new string[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write("Physics: ");
            marks[i, 0] = double.Parse(Console.ReadLine());
            Console.Write("Chemistry: ");
            marks[i, 1] = double.Parse(Console.ReadLine());
            Console.Write("Maths: ");
            marks[i, 2] = double.Parse(Console.ReadLine());
            percent[i] = (marks[i,0] + marks[i,1] + marks[i,2]) / 3;
            grade[i] = percent[i] >= 90 ? "A" :
                       percent[i] >= 75 ? "B" :
                       percent[i] >= 60 ? "C" : "D";
        }
        for (int i = 0; i < n; i++)
            Console.WriteLine($"{percent[i]}% Grade {grade[i]}"); // output
    }
}
