// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor - CarDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/08
// ==================================

namespace AutoLot.Blazor.Services;

public class CarDataService : DataServiceBase, ICarDataService
{
    public Task<Car> GetEntityAsync(
        int id) => Task.FromResult(Cars.FirstOrDefault(c => c.Id == id));

    public Task<IEnumerable<Car>> GetAllEntitiesAsync() => Task.FromResult(Cars.AsEnumerable());

    public Task<Car> AddEntityAsync(
        Car entity)
    {
        entity.Id = Cars.Max(c => c.Id) + 1;
        entity.MakeNavigation = Makes.FirstOrDefault(m => m.Id == entity.MakeId);
        Cars.Add(entity);
        return Task.FromResult(entity);
    }

    public Task<Car> UpdateEntityAsync(
        Car entity)
    {
        var car = Cars.FirstOrDefault(c => c.Id == entity.Id);
        if (car != null)
        {
            car.MakeId = entity.MakeId;
            car.Color = entity.Color;
            car.PetName = entity.PetName;
            car.Price = entity.Price;
            car.IsDrivable = entity.IsDrivable;
            car.MakeNavigation = Makes.FirstOrDefault(m => m.Id == entity.MakeId);
        }

        return Task.FromResult(car);
    }

    public Task DeleteEntityAsync(
        Car entity)
    {
        var car = Cars.FirstOrDefault(c => c.Id == entity.Id);
        if (car != null)
        {
            Cars.Remove(car);
        }
        return Task.CompletedTask;
    }

    public Task<IEnumerable<Car>> GetByMakeAsync(
        int makeId) => Task.FromResult(Cars.Where(c => c.MakeId == makeId).AsEnumerable());
}