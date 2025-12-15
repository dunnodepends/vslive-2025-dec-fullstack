// Copyright Information
// ==================================
// AutoLot - AutoLot.Services - ICarDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/04
// ==================================

namespace AutoLot.Services.DataServices.Interfaces;

public interface ICarDataService : IDataServiceBase<Car>
{
    Task<IQueryable<Car>> GetAllByMakeIdAsync(
        int? makeId);
}