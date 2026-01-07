using System;

// Interface for department
interface IDepartment
{
    void AssignDepartment(string dept);
    string GetDepartmentDetails();
}

// Abstract Employee class
abstract class Employee
{
    private int employeeId;
    private string name;
    private double baseSalary;

    public void SetEmployeeId(int id) { employeeId = id; }
    public int GetEmployeeId() { return employeeId; }

    public void SetName(string n) { name = n; }
    public string GetName() { return name; }

    public void SetBaseSalary(double salary) { baseSalary = salary; }
    public double GetBaseSalary() { return baseSalary; }

    // Display details (common for all employees)
    public void DisplayDetails()
    {
        Console.WriteLine("Employee ID: " + GetEmployeeId());
        Console.WriteLine("Name: " + GetName());
        Console.WriteLine("Base Salary: " + GetBaseSalary());
    }

    // Abstract method for salary calculation
    public abstract double CalculateSalary();
}

// Full-time employee
class FullTimeEmployee : Employee, IDepartment
{
    private string department;

    public void AssignDepartment(string dept) { department = dept; }
    public string GetDepartmentDetails() { return department; }

    // Override abstract method
    public override double CalculateSalary()
    {
        return GetBaseSalary() + (0.2 * GetBaseSalary()); // 20% bonus
    }

    // Display full-time employee details
    public void DisplayFullTime()
    {
        DisplayDetails();
        Console.WriteLine("Department: " + GetDepartmentDetails());
        Console.WriteLine("Total Salary: " + CalculateSalary());
    }
}

// Part-time employee
class PartTimeEmployee : Employee, IDepartment
{
    private string department;
    private int workHours;

    public void AssignDepartment(string dept) { department = dept; }
    public string GetDepartmentDetails() { return department; }

    public void SetWorkHours(int hours) { workHours = hours; }
    public int GetWorkHours() { return workHours; }

    // Override abstract method
    public override double CalculateSalary()
    {
        return GetWorkHours() * GetBaseSalary(); // hourly salary
    }

    // Display part-time employee details
    public void DisplayPartTime()
    {
        DisplayDetails();
        Console.WriteLine("Department: " + GetDepartmentDetails());
        Console.WriteLine("Work Hours: " + GetWorkHours());
        Console.WriteLine("Total Salary: " + CalculateSalary());
    }
}

// Main program
class Program
{
    static void Main()
    {
        FullTimeEmployee fte = new FullTimeEmployee();
        fte.SetEmployeeId(1);
        fte.SetName("Rahul");
        fte.SetBaseSalary(50000);
        fte.AssignDepartment("IT");

        PartTimeEmployee pte = new PartTimeEmployee();
        pte.SetEmployeeId(2);
        pte.SetName("Anita");
        pte.SetBaseSalary(500); // per hour
        pte.SetWorkHours(80);
        pte.AssignDepartment("HR");

        Console.WriteLine("Full Time Employee Details:");
        fte.DisplayFullTime();

        Console.WriteLine("Part Time Employee Details:");
        pte.DisplayPartTime();
    }
}
