using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter("secure.csv");

        string salary = "50000";
        string encrypted = Convert.ToBase64String(
            System.Text.Encoding.UTF8.GetBytes(salary));

        sw.WriteLine("Salary");
        sw.WriteLine(encrypted);

        sw.Close();
    }
}
