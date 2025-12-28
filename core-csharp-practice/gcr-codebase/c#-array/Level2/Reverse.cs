using System;
class Reverse
{
    static void Main()
    {
        Console.Write("Enter number: "); // input
        int num = int.Parse(Console.ReadLine());
        int temp = num, count = 0;
        while (temp != 0) { count++; temp /= 10; }
        int[] digits = new int[count];
        for (int i = 0; i < count; i++)
        {
            digits[i] = num % 10;
            num /= 10;
        }
        Console.Write("Reversed: "); //output
        for (int i = 0; i < count; i++)
            Console.Write(digits[i]);
    }
}
