using Microsoft.AspNetCore.Mvc;
using NationalParksApi.Models;

namespace NationalParksApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class NationalParksController : Controller
{
  private readonly NationalParksApiContext _db;

  public NationalParksController(NationalParksApiContext db)
  {
      _db = db;
  }
}
