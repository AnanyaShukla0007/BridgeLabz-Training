using System;
using System.IO;

class ReadLargeFileErrors
{
    static void Main()
    {
        using (StreamReader reader = new StreamReader("largeLog.txt"))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                if (line.ToLower().Contains("error"))
                    Console.WriteLine(line);
            }
        }
    }
}
