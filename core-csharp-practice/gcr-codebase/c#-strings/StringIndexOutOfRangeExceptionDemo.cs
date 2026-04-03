using System;
class StringIndexOutOfRange
{
    static void Main()
    {
        try
        {
            String s="Hello";
            Console.WriteLine(s[10]);
        }
        catch(IndexOutOfRangeException)
        {
            Console.WriteLine("IndexOutOfRangeException Caught")
        }
    }
}