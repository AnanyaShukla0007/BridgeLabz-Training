using System;
using System.Text;

class ReverseString
{
    static void Main()
    {
        Console.Write("Enter string: ");
        string input = Console.ReadLine();

        StringBuilder sb = new StringBuilder(input);

        // Reverse using two-pointer technique
        int i = 0, j = sb.Length - 1;
        while (i < j)
        {
            char temp = sb[i];
            sb[i] = sb[j];
            sb[j] = temp;
            i++; j--;
        }

        Console.WriteLine("Reversed String: " + sb);
    }
}
