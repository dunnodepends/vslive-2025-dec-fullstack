// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Blazor - IBrowserStorageService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/10/02
// ==================================

namespace AutoLot.Blazor.Services.Storage.Interfaces;

public interface IBrowserStorageService<TItem>
{
    Task SetItemAsync(string key, TItem item);
    Task<TItem> GetItemAsync(string key);
}