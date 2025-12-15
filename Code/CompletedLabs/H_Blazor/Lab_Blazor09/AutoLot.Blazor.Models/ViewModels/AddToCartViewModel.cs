// Copyright Information
// ==================================
// AutoLot-Temp - AutoLot.Blazor.Models - AddToCartViewModel.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/13
// ==================================

namespace AutoLot.Blazor.Models.ViewModels;

public class AddToCartViewModel
{
    public int Id { get; set; }
    [DisplayName("Stock Quantity")]
    public int StockQuantity { get; set; }
    public int ItemId { get; set; }
    [Required]
    [MustBeGreaterThanZero]
    [MustNotBeGreaterThan(nameof(StockQuantity))]
    public int Quantity { get; set; }
}
