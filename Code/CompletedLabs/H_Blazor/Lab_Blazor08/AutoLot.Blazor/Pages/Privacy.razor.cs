using Microsoft.AspNetCore.Components;

namespace AutoLot.Blazor.Pages;

public partial class Privacy
{
    [Parameter]
    public string RouteParameter { get; set; }
    [Parameter]
    [SupplyParameterFromQuery(Name = "QueryStringParam")]
    public string QueryStringParameter { get; set; }
}