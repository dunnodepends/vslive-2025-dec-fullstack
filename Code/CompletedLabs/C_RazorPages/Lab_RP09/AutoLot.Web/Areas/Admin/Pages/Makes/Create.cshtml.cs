// Copyright Information
// ==================================
// AutoLot9 - AutoLot.Web - Create.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/07/10
// ==================================

namespace AutoLot.Web.Areas.Admin.Pages.Makes;
public class CreateModel(IAppLogging appLogging, IMakeDataService makeDataService)
  : BasePageModel<Make>(appLogging, makeDataService, "Create")
{
  public void OnGet() => Entity = new Make();
  public async Task<IActionResult> OnPostAsync() => await SaveOneAsync(MainDataService.AddAsync);
}
