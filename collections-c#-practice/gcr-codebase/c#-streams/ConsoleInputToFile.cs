using System;
using System.IO;

class ConsoleInputToFile
{
    static void Main()
    {
        try
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            Console.Write("Enter Age: ");
            string age = Console.ReadLine();

            Console.Write("Favorite Language: ");
            string language = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter("userInfo.txt"))
            {
                writer.WriteLine("Name: " + name);
                writer.WriteLine("Age: " + age);
                writer.WriteLine("Language: " + language);
            }

            Console.WriteLine("Data saved successfully.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}
