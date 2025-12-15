// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Index.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/04
// ==================================

namespace AutoLot.Web.Pages.Cars;

public class IndexModel(
    ICarDataService carDataService,
    IAppLogging appLogging) : BasePageModel<Car>(appLogging, carDataService, "Inventory")
{
    public string MakeName { get; set; }
    public int? MakeId { get; set; }
    public IList<Car> CarRecords { get; set; }

    public async Task OnGetAsync(int? makeId, string makeName)
    {
        MakeId = makeId;
        if (!makeId.HasValue)
        {
            MakeName = "All Makes";
            CarRecords = (await MainDataService.GetAllAsync()).ToList();
        }
        else
        {
            MakeName = makeName;
            CarRecords = (await ((ICarDataService)MainDataService).GetAllByMakeIdAsync(makeId)).ToList();
        }
    }
}