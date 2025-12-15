// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor - SessionStorageService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/13
// ==================================

namespace AutoLot.Blazor.Services.Storage;

public class SessionStorageService<TItem>(
    IJSRuntime jsRuntime) : IBrowserStorageService<TItem>
{
    public async Task SetItemAsync(
        string key,
        TItem item)
    {
        await jsRuntime.InvokeVoidAsync("skimedicInterop.setSessionStorage", key, JsonSerializer.Serialize(item));
    }

    public async Task<TItem> GetItemAsync(
        string key)
    {
        var json = await jsRuntime.InvokeAsync<string>("skimedicInterop.getSessionStorage", key);
        return json == null ? default : JsonSerializer.Deserialize<TItem>(json);
    }
}