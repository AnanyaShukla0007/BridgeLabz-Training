using System;

class Person
{
    public string Name;
    public int Age;
}

class Teacher : Person
{
    public string Subject;
}

class Student : Person
{
    public string Grade;
}

class Staff : Person
{
    public string Department;
}

class Program
{
    static void Main()
    {
        Student s = new Student();
        s.Name = "Ana";
        s.Age = 20;
        s.Grade = "A";

        Console.WriteLine(s.Name + " " + s.Grade);
    }
}
