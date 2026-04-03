using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class TodoAttribute : Attribute
{
    public string Task { get; }
    public string AssignedTo { get; }
    public string Priority { get; }

    public TodoAttribute(string task, string assignedTo, string priority = "MEDIUM")
    {
        Task = task;
        AssignedTo = assignedTo;
        Priority = priority;
    }
}

class Project
{
    [Todo("Fix bug", "Ana")]
    [Todo("Optimize code", "Ravi", "HIGH")]
    public void Develop() { }
}

class Program
{
    static void Main()
    {
        MethodInfo m = typeof(Project).GetMethod("Develop");
        foreach (TodoAttribute t in m.GetCustomAttributes<TodoAttribute>())
            Console.WriteLine($"{t.Task} - {t.AssignedTo} - {t.Priority}");
    }
}
