using System;
public class UniversityDiscount
{
    public static void Main(String[] args)
    {
        double fees = double.Parse(Console.ReadLine());
        double discount = double.Parse(Console.ReadLine());
        double discounted = (fees * discount) / 100;
        double final = fees - discounted;
        Console.WriteLine("The discount amount in INR is " + discounted + " and final discounted fees is " + final);
    }
}