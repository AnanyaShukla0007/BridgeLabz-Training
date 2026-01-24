using System.Text.RegularExpressions;

public class PasswordValidator
{
    public bool IsValid(string password)
    {
        return Regex.IsMatch(password, @"^(?=.*[A-Z])(?=.*\d).{8,}$");
    }
}
