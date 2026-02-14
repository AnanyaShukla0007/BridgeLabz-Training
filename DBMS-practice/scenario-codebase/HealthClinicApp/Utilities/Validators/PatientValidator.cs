using System;
using HealthClinicApp.Core.Exceptions;

namespace HealthClinicApp.Utilities.Validators
{
    /// <summary>
    /// Validates patient-related inputs.
    /// </summary>
    public static class PatientValidator
    {
        public static void ValidateBasicIdentity(string name, DateTime dob)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new ValidationException("Patient name cannot be empty.");

            if (dob.Date >= DateTime.Today)
                throw new ValidationException("Date of birth must be before today.");
        }

        public static void ValidateFullDetails(
            string phone,
            string email,
            string bloodGroup)
        {
            if (!RegexRules.PhoneRegex.IsMatch(phone))
                throw new ValidationException("Phone number must be exactly 10 digits.");

            if (!RegexRules.EmailRegex.IsMatch(email))
                throw new ValidationException("Invalid email format.");

            if (!RegexRules.BloodGroupRegex.IsMatch(bloodGroup))
                throw new ValidationException("Invalid blood group.");
        }
    }
}
