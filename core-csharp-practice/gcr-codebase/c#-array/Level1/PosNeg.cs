using System;
class PosNeg
{
    static void Main()
    {
        int[] arr = new int[5]; //initiallised array
        for (int i = 0; i < 5; i++)
        {
            Console.Write("Enter number: "); //input
            arr[i] = int.Parse(Console.ReadLine());
        }
        foreach (int n in arr)
        {
            if (n > 0)
                Console.WriteLine(n % 2 == 0 ? $"{n} is Positive Even" : $"{n} is Positive Odd"); positive even/odd
            else if (n < 0)
                Console.WriteLine($"{n} is Negative"); // negative
            else
                Console.WriteLine("Zero"); // zero
        }
        if (arr[0] == arr[4])
            Console.WriteLine("First and last are equal"); //==
        else if (arr[0] > arr[4])
            Console.WriteLine("First is greater than last"); // >
        else
            Console.WriteLine("First is less than last"); // <
    }
}
