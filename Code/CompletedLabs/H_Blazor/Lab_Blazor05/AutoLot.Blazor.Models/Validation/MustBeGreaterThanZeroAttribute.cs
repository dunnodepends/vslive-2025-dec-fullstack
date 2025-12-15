// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor.Models - MustBeGreaterThanZeroAttribute.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/07
// ==================================

namespace AutoLot.Blazor.Models.Validation;

public class MustBeGreaterThanZeroAttribute(string errorMessage)
    : ValidationAttribute(errorMessage)
{
    public MustBeGreaterThanZeroAttribute() : this("{0} must be greater than 0") { }
    public override string FormatErrorMessage(string name) 
        => string.Format(ErrorMessageString, name);
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
        if (!int.TryParse(value?.ToString(), out int result))
        {
            return new ValidationResult(FormatErrorMessage(validationContext.DisplayName),
                [validationContext.MemberName]);
        }
        return result > 0
            ? ValidationResult.Success
            : new ValidationResult(FormatErrorMessage(validationContext.DisplayName),
                [validationContext.MemberName]);
    }
}
