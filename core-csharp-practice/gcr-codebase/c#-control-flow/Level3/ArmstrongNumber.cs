using System;
class ArmstrongChecker
{
    static void Main()
    {
        Console.WriteLine("Enter a number:"); //input
        int number = int.Parse(Console.ReadLine());
        int originalNumber = number;
        int sum = 0;
        while (originalNumber != 0) //loop
        {
            int digit = originalNumber % 10;      // Extract last digit
            sum += digit * digit * digit;         // Add cube of digit
            originalNumber /= 10;                  // Remove last digit
        }
        if (sum == number)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }
}
