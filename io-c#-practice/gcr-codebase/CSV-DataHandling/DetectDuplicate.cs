using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader("students.csv");
        HashSet<string> ids = new HashSet<string>();
        string line;

        sr.ReadLine();

        while ((line = sr.ReadLine()) != null)
        {
            string id = line.Split(',')[0];

            if (!ids.Add(id))
            {
                Console.WriteLine("Duplicate: " + line);
            }
        }

        sr.Close();
    }
}
