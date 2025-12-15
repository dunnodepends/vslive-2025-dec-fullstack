// Copyright Information
// ==================================
// AutoLot - AutoLot.Api - BaseCrudController.cs
// All samples copyright Philip Japikse
// http://www.skimedic.com 2025/12/04
// ==================================

namespace AutoLot.Api.Controllers.Base;

[ApiController]
[Route("api/[controller]")]
public abstract class BaseCrudController<TEntity>(
    IAppLogging appLogging,
    IBaseRepo<TEntity> baseRepo)
    : ControllerBase where TEntity : BaseEntity, new()
{
    protected readonly IBaseRepo<TEntity> MainRepoInstance = baseRepo;
    protected readonly IAppLogging AppLoggingInstance = appLogging;

    [HttpGet]
    public virtual ActionResult<List<TEntity>> GetAll() => Ok(MainRepoInstance.GetAllIgnoreQueryFilters().ToList());


    [HttpGet("{id}")]
    public virtual ActionResult<TEntity> GetOne(
        int id)
    {
        var entity = MainRepoInstance.Find(id);
        return entity == null ? NoContent() : Ok(entity);
    }

    [HttpPut("{id}")]
    public virtual ActionResult<TEntity> UpdateOne(
        int id,
        TEntity entity)
    {
        if (id != entity.Id)
        {
            return BadRequest();
        }

        if (!ModelState.IsValid)
        {
            return ValidationProblem(ModelState);
        }

        MainRepoInstance.Update(entity);
        return Ok(entity);
    }

    [HttpPost]
    public virtual ActionResult<TEntity> AddOne(
        TEntity entity)
    {
        if (!ModelState.IsValid)
        {
            return ValidationProblem(ModelState);
        }

        MainRepoInstance.Add(entity);
        return CreatedAtAction(nameof(GetOne), new { id = entity.Id }, entity);
    }

    [HttpDelete("{id}")]
    public virtual IActionResult DeleteOne(
        int id,
        TEntity entity)
    {
        if (id != entity.Id)
        {
            return BadRequest();
        }

        MainRepoInstance.Delete(entity);
        return Ok();
    }
}