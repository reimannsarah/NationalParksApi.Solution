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
}
