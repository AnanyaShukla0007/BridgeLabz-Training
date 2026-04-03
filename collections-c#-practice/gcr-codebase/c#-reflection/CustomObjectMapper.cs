using System;
using System.Collections.Generic;
using System.Reflection;

class User
{
    public int Id;
    public string Name;
}

class ObjectMapper
{
    public static T ToObject<T>(Dictionary<string, object> data)
    {
        T obj = Activator.CreateInstance<T>();
        Type type = typeof(T);

        foreach (var pair in data)
        {
            FieldInfo field = type.GetField(pair.Key);
            if (field != null)
                field.SetValue(obj, pair.Value);
        }
        return obj;
    }
}

class CustomObjectMapper
{
    static void Main()
    {
        var dict = new Dictionary<string, object>
        {
            { "Id", 1 },
            { "Name", "Ana" }
        };

        User user = ObjectMapper.ToObject<User>(dict);
        Console.WriteLine(user.Id + " " + user.Name);
    }
}
