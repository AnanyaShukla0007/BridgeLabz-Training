using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamWriter sw = new StreamWriter("db_employees.csv");

        sw.WriteLine("ID,Name,Department,Salary");
        sw.WriteLine("1,Aman,IT,50000");
        sw.WriteLine("2,Ravi,HR,45000");

        sw.Close();
    }
}
