// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor - CustomFieldClassProvider.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/13
// ==================================

namespace AutoLot.Blazor.Services.Validation;

internal class CustomFieldClassProvider : FieldCssClassProvider
{
    public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier) =>
        editContext.IsValid(fieldIdentifier) ? "validField" : "invalidField";
}
