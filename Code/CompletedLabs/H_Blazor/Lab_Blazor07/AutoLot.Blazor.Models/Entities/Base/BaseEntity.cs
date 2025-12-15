// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor.Models - BaseEntity.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/07
// ==================================

namespace AutoLot.Blazor.Models.Entities.Base;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public long TimeStamp { get; set; }
}
