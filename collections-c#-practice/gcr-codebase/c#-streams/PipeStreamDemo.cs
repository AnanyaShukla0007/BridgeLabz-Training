using System;
using System.IO.Pipes;
using System.Text;
using System.Threading;

class PipeStreamDemo
{
    static void Main()
    {
        AnonymousPipeServerStream server =
            new AnonymousPipeServerStream(PipeDirection.Out, HandleInheritability.Inheritable);

        AnonymousPipeClientStream client =
            new AnonymousPipeClientStream(PipeDirection.In, server.GetClientHandleAsString());

        Thread writer = new Thread(() =>
        {
            byte[] data = Encoding.UTF8.GetBytes("Hello from Writer Thread");
            server.Write(data, 0, data.Length);
            server.Dispose();
        });

        Thread reader = new Thread(() =>
        {
            byte[] buffer = new byte[1024];
            int bytesRead = client.Read(buffer, 0, buffer.Length);
            Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, bytesRead));
        });

        writer.Start();
        reader.Start();
    }
}
