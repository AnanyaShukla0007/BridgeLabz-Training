using System;

class Employee
{
    public string Name;
    public int Id;
    public double Salary;

    public void DisplayDetails()
    {
        Console.WriteLine(Name + " " + Id + " " + Salary);
    }
}

class Manager : Employee
{
    public int TeamSize;
}

class Developer : Employee
{
    public string ProgrammingLanguage;
}

class Intern : Employee
{
    public string InternshipDuration;
}

class Program
{
    static void Main()
    {
        Manager m = new Manager();
        m.Name = "A";
        m.Id = 1;
        m.Salary = 50000;
        m.TeamSize = 5;

        m.DisplayDetails();
    }
}
