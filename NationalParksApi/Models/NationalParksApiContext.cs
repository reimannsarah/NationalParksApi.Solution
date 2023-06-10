using Microsoft.EntityFrameworkCore;

namespace NationalParksApi.Models;

public class NationalParksApiContext : DbContext
{
  public DbSet<NatlPark> NatlParks { get; set; }

  public NationalParksApiContext(DbContextOptions<NationalParksApiContext> options) : base(options) {}
}