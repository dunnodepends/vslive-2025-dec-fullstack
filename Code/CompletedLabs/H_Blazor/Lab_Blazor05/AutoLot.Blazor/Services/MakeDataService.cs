// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Blazor - MakeDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/10/02
// ==================================

namespace AutoLot.Blazor.Services;

public class MakeDataService : DataServiceBase, IMakeDataService
{
    public Task<Make> GetEntityAsync(
        int id) => Task.FromResult(Makes.FirstOrDefault(m => m.Id == id));
    public Task<IEnumerable<Make>> GetAllEntitiesAsync() => Task.FromResult(Makes.AsEnumerable());
    public Task<Make> AddEntityAsync(
        Make entity)
    {
        entity.Id = Makes.Max(m => m.Id) + 1;
        Makes.Add(entity);
        return Task.FromResult(entity);
    }
    public Task<Make> UpdateEntityAsync(
        Make entity)
    {
        var make = Makes.FirstOrDefault(m => m.Id == entity.Id);
        if (make != null)
        {
            make.Name = entity.Name;
        }
        return Task.FromResult(make);
    }
    public Task DeleteEntityAsync(
        Make entity)
    {
        var make = Makes.FirstOrDefault(m => m.Id == entity.Id);
        if (make != null)
        {
            Makes.Remove(make);
        }
        return Task.CompletedTask;
    }
}