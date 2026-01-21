using System;
using System.IO;
using System.Diagnostics;

class BufferedVsUnbufferedCopy
{
    static void Main()
    {
        string source = "largeFile.dat";
        string destBuffered = "bufferedCopy.dat";
        string destUnbuffered = "unbufferedCopy.dat";
        byte[] buffer = new byte[4096];
        Stopwatch sw = new Stopwatch();

        // Unbuffered copy
        sw.Start();
        using (FileStream fsRead = new FileStream(source, FileMode.Open))
        using (FileStream fsWrite = new FileStream(destUnbuffered, FileMode.Create))
        {
            int bytesRead;
            while ((bytesRead = fsRead.Read(buffer, 0, buffer.Length)) > 0)
            {
                fsWrite.Write(buffer, 0, bytesRead);
            }
        }
        sw.Stop();
        Console.WriteLine("Unbuffered Time: " + sw.ElapsedMilliseconds + " ms");

        // Buffered copy
        sw.Restart();
        using (BufferedStream br = new BufferedStream(new FileStream(source, FileMode.Open)))
        using (BufferedStream bw = new BufferedStream(new FileStream(destBuffered, FileMode.Create)))
        {
            int bytesRead;
            while ((bytesRead = br.Read(buffer, 0, buffer.Length)) > 0)
            {
                bw.Write(buffer, 0, bytesRead);
            }
        }
        sw.Stop();
        Console.WriteLine("Buffered Time: " + sw.ElapsedMilliseconds + " ms");
    }
}
