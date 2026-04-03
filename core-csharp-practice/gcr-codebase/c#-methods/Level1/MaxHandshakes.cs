using System;
class HandshakeCalculator
{
    static int CalculateHandshakes(int students)
    {
        return (students * (students - 1)) / 2;
    }
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int students = int.Parse(Console.ReadLine()); //input
        Console.WriteLine("Maximum Handshakes: " + CalculateHandshakes(students)); //output
    }
}
