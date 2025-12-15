// Copyright Information
// ==================================
// AutoLot - AutoLot.Mvc - MakesController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/11/23
// ==================================

using Microsoft.AspNetCore.Mvc;

namespace AutoLot.Mvc.Areas.Admin.Controllers;

[Area("Admin")]
[Route("Admin/[controller]/[action]")]
public class MakesController(IAppLogging appLogging, IMakeRepo baseRepo)
    : BaseCrudController<Make>(appLogging, baseRepo)
{
    protected override SelectList GetLookupValues() => null;

    // GET: Admin/Makes
    [Route("/Admin")]
    [Route("/Admin/[controller]")]
    [Route("/Admin/[controller]/[action]")]
    public override IActionResult Index() => base.Index();
}
