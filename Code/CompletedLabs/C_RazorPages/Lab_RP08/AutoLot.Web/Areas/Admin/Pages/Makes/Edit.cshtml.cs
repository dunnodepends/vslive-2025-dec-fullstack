// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Edit.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/11/26
// ==================================

namespace AutoLot.Web.Areas.Admin.Pages.Makes;
public class EditModel(IAppLogging appLogging, IMakeRepo repo)
  : BasePageModel<Make>(appLogging, repo, "Edit")
{
    public void OnGet(int? id) => GetOneEntity(id);
    public IActionResult OnPost() => SaveOne(BaseRepoInstance.Update);
}