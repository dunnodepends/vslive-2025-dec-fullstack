// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Create.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/11/26
// ==================================

namespace AutoLot.Web.Areas.Admin.Pages.Makes;
public class CreateModel(IAppLogging appLogging, IMakeRepo makeRepo)
  : BasePageModel<Make>(appLogging, makeRepo, "Create")
{
    public void OnGet() => Entity = new Make();
    public IActionResult OnPost() => SaveOne(BaseRepoInstance.Add);
}