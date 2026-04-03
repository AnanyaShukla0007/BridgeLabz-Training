using System;
using System.Reflection;

class Student
{
    public Student()
    {
        Console.WriteLine("Student object created");
    }
}

class DynamicObjectCreation
{
    static void Main()
    {
        Type type = typeof(Student);

        // Create object dynamically
        object obj = Activator.CreateInstance(type);
    }
}
