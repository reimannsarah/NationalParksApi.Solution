using Microsoft.EntityFrameworkCore;

namespace NationalParksApi.Models;

public class NationalParksApiContext : DbContext
{
  public DbSet<NatlPark> NatlParks { get; set; }

  public NationalParksApiContext(DbContextOptions<NationalParksApiContext> options) : base(options) {}

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<NatlPark>()
      .HasData(
        new NatlPark { NatlParkId = 1, Name = "Acadia", Description = "Features the tallest mountain on the Atlantic Coast of the United States."},
        new NatlPark { NatlParkId = 2, Name = "Arches", Description = "Features more than 2,000 natural sanstone arches."},
        new NatlPark { NatlParkId = 3, Name = "Badlands", Description = "Collection of buttes, pinnacles, spires, and mixed grass prairies."},
        new NatlPark { NatlParkId = 4, Name = "Big Bend", Description = "Named for the prominent bend in the Rio Grande along the U.S. -- Mexico border."},
        new NatlPark { NatlParkId = 5, Name = "Biscayne", Description = "Mostly underwater park at the north end of the Florida Keys."}
      );
  }
}