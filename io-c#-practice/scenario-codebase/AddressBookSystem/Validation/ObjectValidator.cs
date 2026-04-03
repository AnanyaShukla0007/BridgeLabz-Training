using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AddressBookSystem.Validation
{
    // Uses REFLECTION to read annotations at runtime
    public class ObjectValidator
    {
        public static void Validate(object obj)
        {
            ValidationContext context = new ValidationContext(obj);
            List<ValidationResult> results = new List<ValidationResult>();

            bool isValid = Validator.TryValidateObject(
                obj,
                context,
                results,
                true   // validate all properties
            );

            if (!isValid)
            {
                foreach (var error in results)
                    throw new ValidationException(error.ErrorMessage);
            }
        }
    }
}
