using System;
public class AreaTriangle
{
    public static void main(String[] args)
    {
        //Inputs values
        double basee = double.Parse(Console.ReadLine());
        double height = double.Parse(Console.ReadLine());
        //Area triangle
        double area = 0.5 * basee * height;
        double areaCm = area * 6.4516; //Conversion
        Console.WriteLine("The area of the triangle in square inches is " + area + " and in square centimeters is " + areaCm);

    }
}