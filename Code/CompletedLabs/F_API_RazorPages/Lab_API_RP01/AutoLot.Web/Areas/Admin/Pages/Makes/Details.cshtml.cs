// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Details.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/04
// ==================================

namespace AutoLot.Web.Areas.Admin.Pages.Makes;

public class DetailsModel(
    IAppLogging appLogging,
    IMakeDataService makeDataService)
    : BasePageModel<Make>(appLogging, makeDataService, "Details")
{
    public async Task OnGetAsync(
        int? id) => await GetOneEntityAsync(id);
}