using System;
public class TotalPrice{
  public static void Main(String [] args){
    Console.WriteLine("Enter the unit price of the item: ");
    float up = float.Parse(Console.ReadLine());
    Console.WriteLine("Enter the Quantity to be baught: ");
    int q = int.Parse(Console.ReadLine());
    float total = up*q;
    Console.WriteLine("The total purchase in INR " + total + " if the quantity " + q + " and unit price is INR " + up);
  }
}