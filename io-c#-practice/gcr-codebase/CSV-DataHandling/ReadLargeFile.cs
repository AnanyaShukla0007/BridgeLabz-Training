using System;
using System.IO;

class Program
{
    static void Main()
    {
        // STEP 1: Create large.csv
        StreamWriter sw = new StreamWriter("large.csv");
        sw.WriteLine("ID,Name");

        for (int i = 1; i <= 1000; i++)
        {
            sw.WriteLine(i + ",Student" + i);
        }

        sw.Close();

        Console.WriteLine("large.csv created");
        Console.WriteLine();

        // STEP 2: Read large.csv in chunks
        StreamReader sr = new StreamReader("large.csv");
        string line;
        int count = 0;

        sr.ReadLine(); // skip header

        while ((line = sr.ReadLine()) != null)
        {
            count++;

            if (count % 100 == 0)
            {
                Console.WriteLine("Processed records: " + count);
            }
        }

        sr.Close();

        Console.WriteLine();
        Console.WriteLine("Total records processed: " + count);
    }
}
