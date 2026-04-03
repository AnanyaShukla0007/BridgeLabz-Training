using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
class BugReportAttribute : Attribute
{
    public string Description { get; }
    public BugReportAttribute(string description)
    {
        Description = description;
    }
}

class Software
{
    [BugReport("Null pointer issue")]
    [BugReport("Performance bug")]
    public void Run() { }
}

class Program
{
    static void Main()
    {
        MethodInfo method = typeof(Software).GetMethod("Run");
        object[] bugs = method.GetCustomAttributes(typeof(BugReportAttribute), false);

        foreach (BugReportAttribute bug in bugs)
            Console.WriteLine(bug.Description);
    }
}
