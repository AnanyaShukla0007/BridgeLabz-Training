using System;

class EricTravels
{
    static void Main()
    {
        Console.Write("Enter name: ");
        string name = Console.ReadLine();

        Console.Write("Enter from city: ");
        string fromCity = Console.ReadLine();

        Console.Write("Enter via city: ");
        string viaCity = Console.ReadLine();

        Console.Write("Enter to city: ");
        string toCity = Console.ReadLine();

        Console.Write("Enter distance from-to-via (miles): ");
        double fromToVia = double.Parse(Console.ReadLine());

        Console.Write("Enter distance via-to-final city (miles): ");
        double viaToFinalCity = double.Parse(Console.ReadLine());

        Console.Write("Enter total time taken (hours): ");
        double timeTaken = double.Parse(Console.ReadLine());

        double totalDistance = fromToVia + viaToFinalCity;
        double averageSpeed = totalDistance / timeTaken;

        Console.WriteLine(
        "The results of the trip are: " + name + ", " + totalDistance + ", " + averageSpeed
        );

    }
}
