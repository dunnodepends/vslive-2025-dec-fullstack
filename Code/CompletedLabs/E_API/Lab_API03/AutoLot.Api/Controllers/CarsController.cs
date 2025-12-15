// Copyright Information
// ==================================
// AutoLot - AutoLot.Api - CarsController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/04
// ==================================

namespace AutoLot.Api.Controllers;

public class CarsController(IAppLogging appLogging, ICarRepo carRepo)
    : BaseCrudController<Car>(appLogging, carRepo)
{
    [HttpGet("bymake/{makeId?}")]
    public ActionResult<List<Car>> ByMake(int? makeId)
        => makeId is > 0
            ? Ok(((ICarRepo)MainRepoInstance).GetAllBy(makeId.Value))
            : GetAll();
}