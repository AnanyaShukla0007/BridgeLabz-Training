using System;
class EmployeeBonus
{
    static void Main()
    {
        Random r = new Random();
        double totalBonus = 0;
        for (int i = 1; i <= 10; i++)
        {
            double salary = r.Next(20000, 99999);
            int years = r.Next(1, 10);
            double bonus = years > 5 ? salary * 0.05 : salary * 0.02;
            totalBonus += bonus;
        }
        Console.WriteLine("Total Bonus: " + totalBonus);
    }
}
