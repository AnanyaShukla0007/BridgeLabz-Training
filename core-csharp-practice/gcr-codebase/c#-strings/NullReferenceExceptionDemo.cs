using System;
class NullReferenceExceptionDemo
{
    static void Main()
    {
        try
        {
            String s=null;
            Console.WriteLine(s.length);
        }
        catch (NullReferenceException)
        {
            Console.WriteLine("NullReferenceExption Caught")
        }
    }
}