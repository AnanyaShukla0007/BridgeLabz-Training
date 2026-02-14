namespace TechVille.Utilities
{
    public static class ValidationUtil
    {
        public static bool IsEmpty(string value) => string.IsNullOrWhiteSpace(value);
    }
}
