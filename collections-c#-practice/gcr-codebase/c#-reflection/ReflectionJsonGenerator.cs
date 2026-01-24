using System;
using System.Reflection;
using System.Text;

class Product
{
    public int Id = 1;
    public string Name = "Laptop";
}

class ReflectionJsonGenerator
{
    static void Main()
    {
        Product p = new Product();
        Type type = typeof(Product);

        StringBuilder json = new StringBuilder("{");

        FieldInfo[] fields = type.GetFields();

        for (int i = 0; i < fields.Length; i++)
        {
            json.Append($"\"{fields[i].Name}\":\"{fields[i].GetValue(p)}\"");
            if (i < fields.Length - 1) json.Append(",");
        }

        json.Append("}");
        Console.WriteLine(json);
    }
}
