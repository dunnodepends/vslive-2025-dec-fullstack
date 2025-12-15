// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Blazor - MakeApiDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/10/02
// ==================================

namespace AutoLot.Blazor.Services;

public class MakeApiDataService(
    IMakeApiServiceWrapper serviceWrapper) : IMakeDataService
{
    internal Make CreateCleanMake(
        Make entity) => new()
    {
        Id = entity.Id,
        Name = entity.Name,
        TimeStamp = entity.TimeStamp
    };
    public async Task<Make> GetEntityAsync(
        int id) => await serviceWrapper.GetEntityAsync(id);

    public async Task<IEnumerable<Make>> GetAllEntitiesAsync() => await serviceWrapper.GetAllEntitiesAsync();

    public async Task<Make> AddEntityAsync(
        Make entity) => await serviceWrapper.AddEntityAsync(CreateCleanMake(entity));
    public async Task<Make> UpdateEntityAsync(
        Make entity) => await serviceWrapper.UpdateEntityAsync(CreateCleanMake(entity));
    public async Task DeleteEntityAsync(
        Make entity) => await serviceWrapper.DeleteEntityAsync(CreateCleanMake(entity));
}