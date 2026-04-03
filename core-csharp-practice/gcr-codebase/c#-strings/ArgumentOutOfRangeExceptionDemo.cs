using System;
class ArgumentOutOfRangeExceptionDemo
{
    static void Main()
    {
        try
        {
            String s="Hello";
            Console.WriteLine(s.Substring(5,10))
        }
        catch(ArgumentOutOfRangeException)
        {
            Console.WriteLine("ArgumentOutOfRangeException caught. ")
        }
    }
}