using System;
class LargeSecondLarge
{
    static void Main()
    {
        Console.Write("Enter number: "); //input
        int num = int.Parse(Console.ReadLine());
        int maxDigit = 10, index = 0;
        int[] digits = new int[maxDigit];
        while (num != 0 && index < maxDigit)
        {
            digits[index++] = num % 10;
            num /= 10;
        }
        int largest = 0, second = 0;
        for (int i = 0; i < index; i++)
        {
            if (digits[i] > largest)
            {
                second = largest;
                largest = digits[i];
            }
            else if (digits[i] > second && digits[i] != largest)
                second = digits[i];
        }
        Console.WriteLine($"Largest = {largest}"); //output
        Console.WriteLine($"Second Largest = {second}"); //output
    }
}
