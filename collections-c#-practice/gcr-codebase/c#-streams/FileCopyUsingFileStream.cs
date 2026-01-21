using System;
using System.IO;

class FileCopyUsingFileStream
{
    static void Main()
    {
        string sourcePath = "source.txt";
        string destinationPath = "destination.txt";

        try
        {
            if (!File.Exists(sourcePath))
            {
                Console.WriteLine("Source file does not exist.");
                return;
            }

            using (FileStream source = new FileStream(sourcePath, FileMode.Open, FileAccess.Read))
            using (FileStream destination = new FileStream(destinationPath, FileMode.Create, FileAccess.Write))
            {
                int data;
                while ((data = source.ReadByte()) != -1)
                {
                    destination.WriteByte((byte)data);
                }
            }

            Console.WriteLine("File copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
