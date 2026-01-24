using System;
using System.Reflection;
using System.Text;

[AttributeUsage(AttributeTargets.Field)]
class JsonFieldAttribute : Attribute
{
    public string Name { get; }
    public JsonFieldAttribute(string name)
    {
        Name = name;
    }
}

class User
{
    [JsonField("user_name")]
    public string Name = "Ana";

    [JsonField("user_age")]
    public int Age = 21;
}

class Program
{
    static void Main()
    {
        User u = new User();
        StringBuilder json = new StringBuilder("{");

        foreach (FieldInfo f in typeof(User).GetFields())
        {
            var attr = f.GetCustomAttribute<JsonFieldAttribute>();
            json.Append($"\"{attr.Name}\":\"{f.GetValue(u)}\",");
        }

        json.Length--;
        json.Append("}");
        Console.WriteLine(json);
    }
}
