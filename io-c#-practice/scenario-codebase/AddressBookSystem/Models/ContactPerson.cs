using System;
using System.ComponentModel.DataAnnotations;

namespace AddressBookSystem.Models
{
    // MODEL CLASS (Encapsulation)
    // UC-1: Represents a Contact Person
    public class ContactPerson
    {
        [Required]
        public string FirstName { get; set; } = "";

        [Required]
        public string LastName { get; set; } = "";

        public string Address { get; set; } = "";

        [Required]
        public string City { get; set; } = "";

        [Required]
        public string State { get; set; } = "";

        [Required]
        public string Zip { get; set; } = "";

        // Regex: Indian phone number
        [Required]
        [RegularExpression(@"^[6-9]\d{9}$", ErrorMessage = "Invalid phone number")]
        public string PhoneNumber { get; set; } = "";

        // Regex: Email validation
        [Required]
        [EmailAddress(ErrorMessage = "Invalid email format")]
        public string Email { get; set; } = "";

        // UC-7: Duplicate check logic
        public override bool Equals(object? obj)
        {
            if (obj is not ContactPerson other) return false;
            return FirstName == other.FirstName && LastName == other.LastName;
        }

        public override int GetHashCode()
        {
            return (FirstName + LastName).GetHashCode();
        }
    }
}
