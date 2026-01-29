using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        StreamReader sr = new StreamReader("employees.csv");
        List<string[]> list = new List<string[]>();
        string line;

        sr.ReadLine();

        while ((line = sr.ReadLine()) != null)
        {
            list.Add(line.Split(','));
        }

        for (int i = 0; i < list.Count; i++)
        {
            for (int j = i + 1; j < list.Count; j++)
            {
                int s1 = int.Parse(list[i][3]);
                int s2 = int.Parse(list[j][3]);

                if (s1 < s2)
                {
                    var temp = list[i];
                    list[i] = list[j];
                    list[j] = temp;
                }
            }
        }

        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(list[i][1] + " - " + list[i][3]);
        }

        sr.Close();
    }
}
