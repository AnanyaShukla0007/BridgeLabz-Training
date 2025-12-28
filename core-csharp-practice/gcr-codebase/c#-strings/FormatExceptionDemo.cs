using System;
class FormatExceptionDemo
{
    static void Main()
    {
        try
        {
            int num = int.Parse("ABC");
        }
        catch(FormatException)
        {
            Console.WriteLine("FormatException caught");
        }
    }
}