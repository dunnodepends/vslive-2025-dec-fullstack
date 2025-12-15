// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor.Models - Make.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/07
// ==================================

namespace AutoLot.Blazor.Models.Entities;

[ValidatableType]
public class Make : BaseEntity
{
    [Required, MaxLength(50)]
    public string Name { get; set; }
    public ICollection<Car> Cars { get; set; } = new List<Car>();
}
