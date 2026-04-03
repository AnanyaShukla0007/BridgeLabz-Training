using System;
using System.IO;

class ReadFile
{
    static void Main()
    {
        StreamReader sr = new StreamReader("students.csv");
        string line;

        sr.ReadLine(); // skip header

        while ((line = sr.ReadLine()) != null)
        {
            string[] data = line.Split(',');

            Console.WriteLine("ID: " + data[0]);
            Console.WriteLine("Name: " + data[1]);
            Console.WriteLine("Age: " + data[2]);
            Console.WriteLine("Marks: " + data[3]);
            Console.WriteLine("------");
        }

        sr.Close();
    }
}
