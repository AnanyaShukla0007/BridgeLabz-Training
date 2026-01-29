using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader("students.csv");
        string line;

        sr.ReadLine();

        while ((line = sr.ReadLine()) != null)
        {
            string[] data = line.Split(',');
            int marks = int.Parse(data[3]);

            if (marks > 80)
            {
                Console.WriteLine(data[1] + " : " + marks);
            }
        }

        sr.Close();
    }
}
