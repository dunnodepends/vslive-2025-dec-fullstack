// Copyright Information
// ==================================
// AutoLot - AutoLot.Web - Details.cshtml.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/11/26
// ==================================

namespace AutoLot.Web.Areas.Admin.Pages.Makes;

public class DetailsModel(
    IAppLogging appLogging,
    IMakeRepo makeRepo)
    : BasePageModel<Make>(appLogging, makeRepo, "Details")
{
    public void OnGet(
        int? id) => GetOneEntity(id);
}