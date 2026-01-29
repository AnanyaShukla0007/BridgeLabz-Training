using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter("employees.csv");

        sw.WriteLine("ID,Name,Department,Salary");
        sw.WriteLine("1,Aman,IT,50000");
        sw.WriteLine("2,Ravi,HR,45000");
        sw.WriteLine("3,Neha,IT,60000");
        sw.WriteLine("4,Pooja,Finance,55000");
        sw.WriteLine("5,Rohit,IT,65000");

        sw.Close();
        Console.WriteLine("CSV file written");
    }
}
