// Copyright Information
// ==================================
// AutoLot8 - AutoLot.Blazor - CarApiDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2024/10/02
// ==================================

namespace AutoLot.Blazor.Services;

public class CarApiDataService(
    ICarApiServiceWrapper serviceWrapper) : ICarDataService
{
    internal Car CreateCleanCar(
        Car entity) => new()
        {
        Id = entity.Id,
            Color = entity.Color,
            DateBuilt = entity.DateBuilt,
            IsDrivable = entity.IsDrivable,
            MakeId = entity.MakeId,
            PetName = entity.PetName,
        Price = entity.Price,
        TimeStamp = entity.TimeStamp
        };

    public async Task<Car> GetEntityAsync(
        int id) => await serviceWrapper.GetEntityAsync(id);

    public async Task<IEnumerable<Car>> GetAllEntitiesAsync()
	=> await serviceWrapper.GetAllEntitiesAsync();

    public async Task<Car> AddEntityAsync(
        Car entity) => await serviceWrapper.AddEntityAsync(CreateCleanCar(entity));

    public async Task<Car> UpdateEntityAsync(
        Car entity) => await serviceWrapper.UpdateEntityAsync(CreateCleanCar(entity));

    public async Task DeleteEntityAsync(
        Car entity) => await serviceWrapper.DeleteEntityAsync(CreateCleanCar(entity));

    public async Task<IEnumerable<Car>> GetByMakeAsync(
        int makeId) => await serviceWrapper.GetCarsByMakeAsync(makeId);
}