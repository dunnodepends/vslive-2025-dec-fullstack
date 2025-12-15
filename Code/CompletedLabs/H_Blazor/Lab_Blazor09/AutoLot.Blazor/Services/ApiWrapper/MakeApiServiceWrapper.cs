// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Blazor - MakeApiServiceWrapper.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/10/02
// ==================================

namespace AutoLot.Blazor.Services.ApiWrapper;

public class MakeApiServiceWrapper(
    HttpClient client,
    IOptionsSnapshot<ApiServiceSettings> apiSettingsSnapshot)
    : ApiServiceWrapperBase<Make>(client, apiSettingsSnapshot, apiSettingsSnapshot.Value.MakeBaseUri),
        IMakeApiServiceWrapper
{
}