using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using NationalParksApi.Models;

namespace NationalParksApi.Controllers;

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
  public async Task<ActionResult<IEnumerable<State>>> GetState()
  {
    return await _db.States
                            .Include(s => s.Parks)
                            .ToListAsync();
  }
}