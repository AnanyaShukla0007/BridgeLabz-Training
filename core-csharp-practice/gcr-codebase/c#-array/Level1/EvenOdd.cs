using System;
class EvenOdd
{
    static void Main()
    {
        Console.Write("Enter a natural number: "); //input 
        int number = int.Parse(Console.ReadLine());
        if (number <= 0)
        {
            Console.WriteLine("Invalid input");
            return;
        }
        int[] odd = new int[number / 2 + 1];
        int[] even = new int[number / 2 + 1];
        int oi = 0, ei = 0;
        for (int i = 1; i <= number; i++)
        {
            if (i % 2 == 0) even[ei++] = i;
            else odd[oi++] = i;
        }
        Console.WriteLine("Odd Numbers:");
        for (int i = 0; i < oi; i++) Console.Write(odd[i] + " "); // odd number
        Console.WriteLine("\nEven Numbers:");
        for (int i = 0; i < ei; i++) Console.Write(even[i] + " "); // even number
    }
}
