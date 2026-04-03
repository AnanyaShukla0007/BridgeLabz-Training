using System;
using System.IO;

class Program
{
    static void Main()
    {
        StreamReader sr1 = new StreamReader("students.csv");
        StreamReader sr2 = new StreamReader("employees.csv");
        StreamWriter sw = new StreamWriter("merged.csv");

        string line1;
        string line2;

        // read headers
        string header1 = sr1.ReadLine();
        string header2 = sr2.ReadLine();

        sw.WriteLine(header1 + ",Department,Salary");

        // read first data line of employees
        line2 = sr2.ReadLine();

        while ((line1 = sr1.ReadLine()) != null && line2 != null)
        {
            string[] sData = line1.Split(',');
            string[] eData = line2.Split(',');

            // match IDs
            if (sData[0] == eData[0])
            {
                sw.WriteLine(
                    sData[0] + "," +
                    sData[1] + "," +
                    sData[2] + "," +
                    sData[3] + "," +
                    eData[2] + "," +
                    eData[3]
                );

                line2 = sr2.ReadLine();
            }
        }

        sr1.Close();
        sr2.Close();
        sw.Close();

        Console.WriteLine("Merge completed");
    }
}
