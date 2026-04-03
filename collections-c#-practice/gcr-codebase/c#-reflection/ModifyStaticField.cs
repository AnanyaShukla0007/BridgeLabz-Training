using System;
using System.Reflection;

class Configuration
{
    private static string API_KEY = "OLD_KEY";
}

class ModifyStaticField
{
    static void Main()
    {
        Type type = typeof(Configuration);

        FieldInfo field = type.GetField("API_KEY",
            BindingFlags.NonPublic | BindingFlags.Static);

        field.SetValue(null, "NEW_API_KEY");

        Console.WriteLine("Updated API_KEY: " + field.GetValue(null));
    }
}
