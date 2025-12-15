namespace AutoLot.Blazor.Models.Validation;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddModelValidation(this IServiceCollection services)
        => services.AddValidation();
}