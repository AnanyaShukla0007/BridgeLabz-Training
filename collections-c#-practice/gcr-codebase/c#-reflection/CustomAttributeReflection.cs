using System;
using System.Reflection;

[AttributeUsage(AttributeTargets.Class)]
class AuthorAttribute : Attribute
{
    public string Name { get; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

[Author("Ana")]
class Book { }

class CustomAttributeReflection
{
    static void Main()
    {
        Type type = typeof(Book);

        AuthorAttribute attr =
            (AuthorAttribute)Attribute.GetCustomAttribute(
                type, typeof(AuthorAttribute));

        Console.WriteLine("Author: " + attr.Name);
    }
}
