using System;
using System.IO;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader("users.csv");
        string line;
        Regex emailRegex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        sr.ReadLine();

        while ((line = sr.ReadLine()) != null)
        {
            string[] data = line.Split(',');

            if (!emailRegex.IsMatch(data[2]) || data[3].Length != 10)
            {
                Console.WriteLine("Invalid Row: " + line);
            }
        }

        sr.Close();
    }
}
