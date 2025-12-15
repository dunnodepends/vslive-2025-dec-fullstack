// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor - ICarDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/08
// ==================================

namespace AutoLot.Blazor.Services.Interfaces;

public interface ICarDataService : IDataServiceBase<Car>
{
    Task<IEnumerable<Car>> GetByMakeAsync(int makeId);
}
