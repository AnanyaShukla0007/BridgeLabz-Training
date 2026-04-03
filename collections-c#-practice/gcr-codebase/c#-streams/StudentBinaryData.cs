using System;
using System.IO;

class StudentBinaryData
{
    static void Main()
    {
        string file = "student.dat";

        // Write data
        using (BinaryWriter writer = new BinaryWriter(File.Open(file, FileMode.Create)))
        {
            writer.Write(101);
            writer.Write("Ana");
            writer.Write(9.2);
        }

        // Read data
        using (BinaryReader reader = new BinaryReader(File.Open(file, FileMode.Open)))
        {
            int roll = reader.ReadInt32();
            string name = reader.ReadString();
            double gpa = reader.ReadDouble();

            Console.WriteLine($"{roll} {name} {gpa}");
        }
    }
}
