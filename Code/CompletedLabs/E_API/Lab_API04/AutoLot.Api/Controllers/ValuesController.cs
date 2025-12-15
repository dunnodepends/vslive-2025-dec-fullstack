// Copyright Information
// ==================================
// AutoLot - AutoLot.Api - ValuesController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/06
// ==================================

namespace AutoLot.Api.Controllers;


[ApiController]
[Route("api/[controller]")]
public class ValuesController(
    IAppLogging appLogging) : ControllerBase
{
    [HttpGet("problem")]
    public IActionResult Problem() => NotFound();

    [HttpGet("logging")]
    public IActionResult TestLogging()
    {
        appLogging.LogAppError("Test error");
        return Ok();
    }

    [HttpGet("error")]
    public IActionResult TestExceptionHandling() => throw new Exception("Test Exception");
}
