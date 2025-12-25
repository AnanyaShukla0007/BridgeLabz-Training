using System;
class LargestSecondLarge
{
    static void Main()
    {
        Console.Write("Enter number: "); //input
        int num = int.Parse(Console.ReadLine());
        int maxDigit = 10, index = 0;
        int[] digits = new int[maxDigit];
        while (num != 0)
        {
            if (index == maxDigit)
            {
                maxDigit += 10;
                int[] temp = new int[maxDigit];
                Array.Copy(digits, temp, index);
                digits = temp;
            }
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
        Console.WriteLine($"Second Largest = {second}"); // output
    }
}
