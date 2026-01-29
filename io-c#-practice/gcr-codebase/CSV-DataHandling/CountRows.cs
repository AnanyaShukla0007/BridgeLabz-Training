using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader("students.csv");
        int count = 0;

        sr.ReadLine(); // header

        while (sr.ReadLine() != null)
        {
            count++;
        }

        sr.Close();
        Console.WriteLine("Total records = " + count);
    }
}
