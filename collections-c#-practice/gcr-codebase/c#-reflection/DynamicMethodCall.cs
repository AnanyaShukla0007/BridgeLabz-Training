using System;
using System.Reflection;

class MathOperations
{
    public int Add(int a, int b) => a + b;
    public int Subtract(int a, int b) => a - b;
    public int Multiply(int a, int b) => a * b;
}

class DynamicMethodCall
{
    static void Main()
    {
        MathOperations obj = new MathOperations();
        Type type = typeof(MathOperations);

        Console.Write("Enter method name: ");
        string methodName = Console.ReadLine();

        MethodInfo method = type.GetMethod(methodName);

        if (method == null)
        {
            Console.WriteLine("Method not found");
            return;
        }

        object result = method.Invoke(obj, new object[] { 10, 5 });
        Console.WriteLine("Result: " + result);
    }
}
