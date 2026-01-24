using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Field)]
class InjectAttribute : Attribute { }

class Service
{
    public void Execute() => Console.WriteLine("Service Executed");
}

class Controller
{
    [Inject]
    public Service service;
}

class SimpleDI
{
    static void Main()
    {
        Controller controller = new Controller();

        foreach (FieldInfo field in typeof(Controller).GetFields())
        {
            if (Attribute.IsDefined(field, typeof(InjectAttribute)))
            {
                object dependency = Activator.CreateInstance(field.FieldType);
                field.SetValue(controller, dependency);
            }
        }

        controller.service.Execute();
    }
}
