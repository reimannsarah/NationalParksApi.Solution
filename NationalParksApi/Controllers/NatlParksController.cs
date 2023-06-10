using Microsoft.AspNetCore.Mvc;
using NationalParksApi.Models;
using Microsoft.EntityFrameworkCore;

namespace NationalParksApi.Controllers;

[ApiController]
[ApiVersion("1.0")]
[Route("api/v{version:ApiVersion}/[controller]")]
public class NationalParksController : Controller
{
  private readonly NationalParksApiContext _db;

  public NationalParksController(NationalParksApiContext db)
  {
      _db = db;
  }

  [HttpGet]
  public async Task<ActionResult<IEnumerable<NatlPark>>> GetNatlParks()
  {
    return await _db.NatlParks.ToListAsync();
  }

  [HttpGet("{id}")]
  public async Task<ActionResult<NatlPark>> GetNatlPark(int id)
  {
    NatlPark natlPark = await _db.NatlParks.FindAsync(id);
    if(natlPark == null)
    {
      return NotFound();
    }
    return natlPark;
  }

  [HttpPut("{id}")]
  public async Task<IActionResult> Put(int id, NatlPark natlPark)
  {
    if (id != natlPark.NatlParkId)
    {
      return BadRequest();
    }
    _db.NatlParks.Update(natlPark);
    try
    {
      await _db.SaveChangesAsync();
    }
    catch(DbUpdateConcurrencyException)
    {
      if(!NatlParkExists(id))
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
  private bool NatlParkExists(int id)
  {
    return _db.NatlParks.Any(e => e.NatlParkId == id);
  }
}

