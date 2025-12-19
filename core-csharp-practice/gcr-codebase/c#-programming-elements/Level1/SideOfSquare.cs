using System;
public class SideOfSquare{
  public static void Main(String [] args){
    Console.Write("Enter the perimeter: ");
    int p = int.Parse(Console.ReadLine());
    int side = p/4;
    Console.WriteLine("The length of the side is " + side + " whose perimeter is " + p);

  }
}