using System.Text.RegularExpressions;

namespace TechVille.Utilities
{
    public static class RegexUtil
    {
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }
    }
}
