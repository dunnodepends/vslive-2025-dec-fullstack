// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor - DataServiceBase.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/13
// ==================================

namespace AutoLot.Blazor.Services.Base;

public abstract class DataServiceBase
{
    protected List<Make> Makes { get; init; }
    protected List<Car> Cars { get; init; }

    protected DataServiceBase()
    {
        Makes =
        [
            new Make { Id = 1, Name = "VW" },
            new Make { Id = 2, Name = "Ford" },
            new Make { Id = 3, Name = "Saab" },
            new Make { Id = 4, Name = "Yugo" },
            new Make { Id = 5, Name = "BMW" },
            new Make { Id = 6, Name = "Pinto" }
        ];
        Cars =
        [
            new Car
            {
                Id = 1, MakeId = 1, Color = "Black", PetName = "Zippy", Price = "$45,000.00",
                MakeNavigation = Makes.First(m => m.Id == 1)
            },
            new Car
            {
                Id = 2, MakeId = 2, Color = "Rust", PetName = "Rusty", Price = "$45,000.00",
                MakeNavigation = Makes.First(m => m.Id == 2)
            },
            new Car
            {
                Id = 3, MakeId = 3, Color = "Black", PetName = "Mel", Price = "$45,000.00",
                MakeNavigation = Makes.First(m => m.Id == 3)
            },
            new Car
            {
                Id = 4, MakeId = 4, Color = "Yellow", PetName = "Clunker", Price = "$45,000.00",
                MakeNavigation = Makes.First(m => m.Id == 4)
            },
            new Car
            {
                Id = 5, MakeId = 5, Color = "Black", PetName = "Bimmer", Price = "$45,000.00",
                MakeNavigation = Makes.First(m => m.Id == 5)
            },
            new Car
            {
                Id = 6, MakeId = 5, Color = "Green", PetName = "Hank", Price = "$45,000.00",
                MakeNavigation = Makes.First(m => m.Id == 5)
            },
            new Car
            {
                Id = 7, MakeId = 5, Color = "Pink", PetName = "Pinky", Price = "$45,000.00",
                MakeNavigation = Makes.First(m => m.Id == 5)
            },
            new Car
            {
                Id = 8, MakeId = 6, Color = "Black", PetName = "Pete", Price = "$45,000.00",
                MakeNavigation = Makes.First(m => m.Id == 6)
            },
            new Car
            {
                Id = 9, MakeId = 4, Color = "Brown", PetName = "Brownie", Price = "$45,000.00",
                MakeNavigation = Makes.First(m => m.Id == 4)
            },
            new Car
            {
                Id = 10, MakeId = 1, Color = "Rust", PetName = "Lemon", IsDrivable = false, Price = "$45,000.00",
                MakeNavigation = Makes.First(m => m.Id == 1)
            }
        ];
    }
}