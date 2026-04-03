using System;

public class Height
{
    public static void Main(string[] args)
    {
        double height = double.Parse(Console.ReadLine());

        double total = height / 2.54;
        int feet = (int)(total / 12);
        double inches = total % 12;

        Console.WriteLine(
            "Your Height in cm is " + height + " while in feet is " + feet + " and inches is " + inches);
    }
}
