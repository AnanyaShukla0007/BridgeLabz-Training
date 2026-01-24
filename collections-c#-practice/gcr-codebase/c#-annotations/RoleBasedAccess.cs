using System;

[AttributeUsage(AttributeTargets.Method)]
class RoleAllowedAttribute : Attribute
{
    public string Role { get; }
    public RoleAllowedAttribute(string role)
    {
        Role = role;
    }
}

class AdminService
{
    [RoleAllowed("ADMIN")]
    public void DeleteData()
    {
        Console.WriteLine("Data Deleted");
    }
}

class Program
{
    static void Main()
    {
        string currentRole = "USER";
        var method = typeof(AdminService).GetMethod("DeleteData");
        var attr = method.GetCustomAttribute<RoleAllowedAttribute>();

        if (attr.Role == currentRole)
            method.Invoke(new AdminService(), null);
        else
            Console.WriteLine("Access Denied!");
    }
}
