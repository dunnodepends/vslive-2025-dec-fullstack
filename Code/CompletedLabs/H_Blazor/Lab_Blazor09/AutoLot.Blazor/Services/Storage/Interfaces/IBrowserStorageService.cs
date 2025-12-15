// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor - IBrowserStorageService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/13
// ==================================

namespace AutoLot.Blazor.Services.Storage.Interfaces;

public interface IBrowserStorageService<TItem>
{
    Task SetItemAsync(string key, TItem item);
    Task<TItem> GetItemAsync(string key);
}
