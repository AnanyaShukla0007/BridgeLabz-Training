using System;
using System.Reflection;

class Sample
{
    public int x;
    private string y;

    public Sample() { }
    public Sample(int a) { }

    public void Show() { }
    private void Hidden() { }
}

class ClassInfoReflection
{
    static void Main()
    {
        Console.Write("Enter class name: ");
        string className = Console.ReadLine();

        // Get Type information
        Type type = Type.GetType(className);

        if (type == null)
        {
            Console.WriteLine("Class not found");
            return;
        }

        Console.WriteLine("\nMethods:");
        foreach (MethodInfo m in type.GetMethods(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(m.Name);
        }

        Console.WriteLine("\nFields:");
        foreach (FieldInfo f in type.GetFields(
            BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance))
        {
            Console.WriteLine(f.Name);
        }

        Console.WriteLine("\nConstructors:");
        foreach (ConstructorInfo c in type.GetConstructors())
        {
            Console.WriteLine(c.ToString());
        }
    }
}
