using System;

[AttributeUsage(AttributeTargets.Field)]
class MaxLengthAttribute : Attribute
{
    public int Length { get; }
    public MaxLengthAttribute(int length)
    {
        Length = length;
    }
}

class User
{
    [MaxLength(10)]
    public string Username;

    public User(string username)
    {
        var attr = (MaxLengthAttribute)
            Attribute.GetCustomAttribute(
                typeof(User).GetField("Username"),
                typeof(MaxLengthAttribute));

        if (username.Length > attr.Length)
            throw new ArgumentException("Username too long");

        Username = username;
    }
}
