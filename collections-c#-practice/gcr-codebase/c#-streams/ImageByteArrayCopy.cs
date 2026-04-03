using System;
using System.IO;

class ImageByteArrayCopy
{
    static void Main()
    {
        try
        {
            byte[] imageBytes = File.ReadAllBytes("input.jpg");

            using (MemoryStream ms = new MemoryStream(imageBytes))
            {
                File.WriteAllBytes("output.jpg", ms.ToArray());
            }

            Console.WriteLine("Image copied successfully.");
        }
        catch (IOException ex)
        {
            Console.WriteLine("IO Error: " + ex.Message);
        }
    }
}
