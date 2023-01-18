using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Practice.Infastructure.Attributes
{
    public class GeorgianOnlyAttribute : ValidationAttribute
    {
        private readonly string? pattern = @"[ა-ჰ]";

        protected override ValidationResult? IsValid(object? value, ValidationContext validationContext)
        {
            if (value is string)
            {
                if (Regex.IsMatch(value.ToString()!, pattern!, RegexOptions.IgnoreCase))
                {
                    return ValidationResult.Success;
                }
            }

            return new ValidationResult("შეიყვანეთ მხოლოდ ქართული სიმბოლოები");
        }
    }
}
