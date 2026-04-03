using System.Text.RegularExpressions;

namespace HealthClinicApp.Utilities.Validators
{
    /// <summary>
    /// Centralized regex rules for validation.
    /// </summary>
    public static class RegexRules
    {
        public static readonly Regex PhoneRegex =
            new(@"^[0-9]{10}$");

        public static readonly Regex EmailRegex =
            new(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

        // Allowed blood groups only
        public static readonly Regex BloodGroupRegex =
            new(@"^(A|B|AB|O)[+-]$");
    }
}
