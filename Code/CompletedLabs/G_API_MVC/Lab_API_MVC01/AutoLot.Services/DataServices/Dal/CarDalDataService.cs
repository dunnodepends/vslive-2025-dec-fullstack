// Copyright Information
// ==================================
// AutoLot - AutoLot.Services - CarDalDataService.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/04
// ==================================

namespace AutoLot.Services.DataServices.Dal;

public class CarDalDataService(
    IAppLogging appLoggingInstance,
    ICarRepo carRepoInstance)
    : DalDataServiceBase<Car>(appLoggingInstance, carRepoInstance), ICarDataService
{
    public async Task<IQueryable<Car>> GetAllByMakeIdAsync(
        int? makeId)
        => await Task.Run(() => makeId.HasValue
            ? ((ICarRepo)BaseRepoInstance).GetAllBy(makeId.Value)
            : ((ICarRepo)BaseRepoInstance).GetAllIgnoreQueryFilters());
}