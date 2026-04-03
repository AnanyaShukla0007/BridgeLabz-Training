using System;
class MaxHandshake
{
    static void Main()
    {
        Console.Write("Enter number of students: ");
        int numberOfStudents = int.Parse(Console.ReadLine()); //input
        int handshakes = (numberOfStudents * (numberOfStudents - 1)) / 2;
        Console.WriteLine("Maximum number of possible handshakes: " + handshakes); //output
    }
}
