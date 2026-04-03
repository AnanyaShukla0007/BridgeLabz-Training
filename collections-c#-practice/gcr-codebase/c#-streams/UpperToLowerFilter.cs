using System;
using System.IO;

class UpperToLowerFilter
{
    static void Main()
    {
        try
        {
            using (StreamReader reader = new StreamReader("input.txt"))
            using (StreamWriter writer = new StreamWriter("output.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    writer.WriteLine(line.ToLower());
                }
            }

            Console.WriteLine("Conversion completed.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
