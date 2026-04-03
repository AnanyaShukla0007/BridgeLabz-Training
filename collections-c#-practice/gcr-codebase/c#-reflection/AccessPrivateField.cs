using System;
using System.Reflection;

class Person
{
    private int age = 25;
}

class AccessPrivateField
{
    static void Main()
    {
        Person p = new Person();
        Type type = typeof(Person);

        // Access private field
        FieldInfo field = type.GetField("age",
            BindingFlags.NonPublic | BindingFlags.Instance);

        field.SetValue(p, 30);

        Console.WriteLine("Modified Age: " + field.GetValue(p));
    }
}
