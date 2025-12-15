// Copyright Information
// ==================================
// AutoLot - AutoLot.Api - ContentNegotiationController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/06
// ==================================

namespace AutoLot.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ContentNegotiationController : ControllerBase
{
    [HttpGet]
    [Produces("application/json", "application/xml", "text/csv")]
    public IActionResult Get(IDriverRepo driverRepo) => Ok(driverRepo.GetAll().ToList());
}