using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader("employees.csv");
        StreamWriter sw = new StreamWriter("updated_employees.csv");

        string line;
        sw.WriteLine(sr.ReadLine());

        while ((line = sr.ReadLine()) != null)
        {
            string[] data = line.Split(',');

            if (data[2] == "IT")
            {
                int sal = int.Parse(data[3]);
                sal = sal + (sal * 10 / 100);
                data[3] = sal.ToString();
            }

            sw.WriteLine(data[0] + "," + data[1] + "," + data[2] + "," + data[3]);
        }

        sr.Close();
        sw.Close();
    }
}
