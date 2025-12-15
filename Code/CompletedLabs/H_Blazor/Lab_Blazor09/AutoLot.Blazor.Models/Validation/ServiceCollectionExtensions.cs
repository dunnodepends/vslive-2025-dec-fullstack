// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor.Models - ServiceCollectionExtensions.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/13
// ==================================

namespace AutoLot.Blazor.Models.Validation;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddModelValidation(this IServiceCollection services)
        => services.AddValidation();
}