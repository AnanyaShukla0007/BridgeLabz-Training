using System;

class FirstNegative
{
    static void Main()
    {
        int[] arr = { 5, 3, -2, 7, -9 };

        // Traverse array one by one
        foreach (int num in arr)
        {
            if (num < 0)
            {
                Console.WriteLine("First Negative Number: " + num);
                return;
            }
        }

        Console.WriteLine("No negative number found");
    }
}
