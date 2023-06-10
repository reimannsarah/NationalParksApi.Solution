using Microsoft.EntityFrameworkCore;

namespace NationalParksApi.Models;

public class NationalParksApiContext : DbContext
{
  public DbSet<NatlPark> NatlParks { get; set; }
  public DbSet<State> States { get; set; }

  public NationalParksApiContext(DbContextOptions<NationalParksApiContext> options) : base(options) {}

  protected override void OnModelCreating(ModelBuilder builder)
  {
    builder.Entity<State>()
      .HasData(
        new State { StateId = 1, Name = "Alabama" },
        new State { StateId = 2, Name = "Alaska" },
        new State { StateId = 3, Name = "Arizona" },
        new State { StateId = 4, Name = "Arkansas" },
        new State { StateId = 5, Name = "California" },
        new State { StateId = 6, Name = "Colorado" },
        new State { StateId = 7, Name = "Connecticut" },
        new State { StateId = 8, Name = "Delaware" },
        new State { StateId = 9, Name = "Florida" },
        new State { StateId = 10, Name = "Georgia" },
        new State { StateId = 11, Name = "Hawaii" },
        new State { StateId = 12, Name = "Idaho" },
        new State { StateId = 13, Name = "Illinois" },
        new State { StateId = 14, Name = "Indiana" },
        new State { StateId = 15, Name = "Iowa" },
        new State { StateId = 16, Name = "Kansas" },
        new State { StateId = 17, Name = "Kentucky" },
        new State { StateId = 18, Name = "Lousiana" },
        new State { StateId = 19, Name = "Maine" },
        new State { StateId = 20, Name = "Maryland" },
        new State { StateId = 21, Name = "Massachusetss" },
        new State { StateId = 22, Name = "Michigan" },
        new State { StateId = 23, Name = "Minnesota" },
        new State { StateId = 24, Name = "Mississippi" },
        new State { StateId = 25, Name = "Missouri" },
        new State { StateId = 26, Name = "Montana" },
        new State { StateId = 27, Name = "Nebraska" },
        new State { StateId = 28, Name = "Nevada" },
        new State { StateId = 29, Name = "New Hampshire" },
        new State { StateId = 30, Name = "New Jersey" },
        new State { StateId = 31, Name = "New Mexico" },
        new State { StateId = 32, Name = "New York" },
        new State { StateId = 33, Name = "North Carolina" },
        new State { StateId = 34, Name = "North Dakota" },
        new State { StateId = 35, Name = "Ohio" },
        new State { StateId = 36, Name = "Oklahoma" },
        new State { StateId = 37, Name = "Oregon" },
        new State { StateId = 38, Name = "Pennsylvania" },
        new State { StateId = 39, Name = "Rhode Island" },
        new State { StateId = 40, Name = "South Carolina" },
        new State { StateId = 41, Name = "South Dakota" },
        new State { StateId = 42, Name = "Tennessee" },
        new State { StateId = 43, Name = "Texas" },
        new State { StateId = 44, Name = "Utah" },
        new State { StateId = 45, Name = "Vermont" },
        new State { StateId = 46, Name = "Virginia" },
        new State { StateId = 47, Name = "Washington" },
        new State { StateId = 48, Name = "West Virginia" },
        new State { StateId = 49, Name = "Wisconsin" },
        new State { StateId = 50, Name = "Wyoming" }
      );


    builder.Entity<NatlPark>()
      .HasData(
        new NatlPark { NatlParkId = 1, Name = "Acadia", Description = "Features the tallest mountain on the Atlantic Coast of the United States.", StateId = 19},
        new NatlPark { NatlParkId = 2, Name = "Arches", Description = "Features more than 2,000 natural sanstone arches.", StateId = 44},
        new NatlPark { NatlParkId = 3, Name = "Badlands", Description = "Collection of buttes, pinnacles, spires, and mixed grass prairies.", StateId = 41},
        new NatlPark { NatlParkId = 4, Name = "Big Bend", Description = "Named for the prominent bend in the Rio Grande along the U.S. -- Mexico border.", StateId = 43},
        new NatlPark { NatlParkId = 5, Name = "Biscayne", Description = "Mostly underwater park at the north end of the Florida Keys.", StateId = 9}
      );
  }
}