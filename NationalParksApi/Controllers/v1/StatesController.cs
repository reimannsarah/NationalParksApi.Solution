using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using NationalParksApi.Models;

namespace NationalParksApi.Controllers.v1;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:ApiVersion}/[controller]")]
public class StatesController : Controller
{
  private readonly NationalParksApiContext _db;

  public StatesController(NationalParksApiContext db)
  {
    _db = db;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<State>>> GetStates()
  {
    return await _db.States
                            .Include(s => s.Parks)
                            .ToListAsync();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<State>> GetState(int id)
  {
    State state = await _db.States
                                  .Include(s => s.Parks)
                                  .FirstOrDefaultAsync(s => s.StateId == id);
    if (state == null)
    {
      return NotFound();
    }
    return state;
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int id, State state)
  {
    if (id != state.StateId)
    {
      return BadRequest();
    }
    _db.States.Update(state);
    try
    {
      await _db.SaveChangesAsync();
    }
    catch(DbUpdateConcurrencyException)
    {
      if(!StateExists(id))
      {
        return NotFound();
      }
      else
      {
        throw;
      }
    }
    return NoContent();
  }
  private bool StateExists(int id)
  {
    return _db.States.Any(e => e.StateId == id);
  }

  [HttpDelete("{id}")]
  public async Task<IActionResult> DeleteState(int id)
  {
    State state = await _db.States.FindAsync(id);
    if(state == null)
    {
      return NotFound();
    }
    _db.States.Remove(state);
    await _db.SaveChangesAsync();

    return NoContent();
  }
}