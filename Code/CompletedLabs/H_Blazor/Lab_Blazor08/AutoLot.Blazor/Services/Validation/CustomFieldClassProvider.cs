namespace AutoLot.Blazor.Services.Validation;

internal class CustomFieldClassProvider : FieldCssClassProvider
{
    public override string GetFieldCssClass(EditContext editContext, in FieldIdentifier fieldIdentifier) =>
        editContext.IsValid(fieldIdentifier) ? "validField" : "invalidField";
}
