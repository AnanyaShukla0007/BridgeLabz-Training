using System;
class ArrayIndexOutOfRangeExceptionDemo
{
    static void Main()
    {
        try
        {
            int[] arr=[1,2,3,4];
            Console.WriteLine(arr[5])
        }
        catch(ArrayIndexOutOfRangeExceptionDemo)
        {
            Console.WriteLine("ArrayIndexOutOfRangeException caught")
        }
    }
}