using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader("employees.csv");
        string line;
        string name = "Neha";

        sr.ReadLine();

        while ((line = sr.ReadLine()) != null)
        {
            string[] data = line.Split(',');

            if (data[1] == name)
            {
                Console.WriteLine("Department: " + data[2]);
                Console.WriteLine("Salary: " + data[3]);
            }
        }

        sr.Close();
    }
}
