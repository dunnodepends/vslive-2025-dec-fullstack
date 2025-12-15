// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor - IDataServiceBase.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/13
// ==================================

namespace AutoLot.Blazor.Services.Interfaces.Base;

public interface IDataServiceBase<TEntity> where TEntity : BaseEntity
{
    Task<TEntity> GetEntityAsync(int id);
    Task<IEnumerable<TEntity>> GetAllEntitiesAsync();
    Task<TEntity> AddEntityAsync(TEntity entity);
    Task<TEntity> UpdateEntityAsync(TEntity entity);
    Task DeleteEntityAsync(TEntity entity);
}
