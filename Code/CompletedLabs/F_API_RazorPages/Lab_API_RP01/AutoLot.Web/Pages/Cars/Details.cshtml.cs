// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Details.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/04
// ==================================

namespace AutoLot.Web.Pages.Cars;

public class DetailsModel(
    ICarDataService carDataService,
    IAppLogging appLogging) : BasePageModel<Car>(appLogging, carDataService, "Details")
{
    public async Task OnGetAsync(int? id)
    {
        if (!id.HasValue)
        {
            Entity = null;
            Error = "Invalid Request";
        }
        else
        {
            await GetOneEntityAsync(id);
            Error = Entity == null ? "Not found" : string.Empty;
        }
    }
}