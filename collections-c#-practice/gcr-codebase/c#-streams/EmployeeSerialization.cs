using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

class Employee
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Department { get; set; }
    public double Salary { get; set; }
}

class EmployeeSerialization
{
    static void Main()
    {
        string filePath = "employees.json";

        List<Employee> employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Ana", Department = "IT", Salary = 70000 },
            new Employee { Id = 2, Name = "Ravi", Department = "HR", Salary = 50000 }
        };

        try
        {
            // Serialize
            string json = JsonSerializer.Serialize(employees);
            File.WriteAllText(filePath, json);

            // Deserialize
            string data = File.ReadAllText(filePath);
            var loadedEmployees = JsonSerializer.Deserialize<List<Employee>>(data);

            foreach (var emp in loadedEmployees)
                Console.WriteLine($"{emp.Id} {emp.Name} {emp.Department} {emp.Salary}");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Serialization Error: " + ex.Message);
        }
    }
}
