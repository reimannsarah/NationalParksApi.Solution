﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NationalParksApi.Models;

#nullable disable

namespace NationalParksApi.Migrations
{
    [DbContext(typeof(NationalParksApiContext))]
    [Migration("20230610200846_AddListParksToStateEntity")]
    partial class AddListParksToStateEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("NationalParksApi.NatlPark", b =>
                {
                    b.Property<int>("NatlParkId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.Property<int>("StateId")
                        .HasColumnType("int");

                    b.HasKey("NatlParkId");

                    b.HasIndex("StateId");

                    b.ToTable("NatlParks");

                    b.HasData(
                        new
                        {
                            NatlParkId = 1,
                            Description = "Features the tallest mountain on the Atlantic Coast of the United States.",
                            Name = "Acadia",
                            StateId = 19
                        },
                        new
                        {
                            NatlParkId = 2,
                            Description = "Features more than 2,000 natural sanstone arches.",
                            Name = "Arches",
                            StateId = 44
                        },
                        new
                        {
                            NatlParkId = 3,
                            Description = "Collection of buttes, pinnacles, spires, and mixed grass prairies.",
                            Name = "Badlands",
                            StateId = 41
                        },
                        new
                        {
                            NatlParkId = 4,
                            Description = "Named for the prominent bend in the Rio Grande along the U.S. -- Mexico border.",
                            Name = "Big Bend",
                            StateId = 43
                        },
                        new
                        {
                            NatlParkId = 5,
                            Description = "Mostly underwater park at the north end of the Florida Keys.",
                            Name = "Biscayne",
                            StateId = 9
                        });
                });

            modelBuilder.Entity("NationalParksApi.State", b =>
                {
                    b.Property<int>("StateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("longtext");

                    b.HasKey("StateId");

                    b.ToTable("States");

                    b.HasData(
                        new
                        {
                            StateId = 1,
                            Name = "Alabama"
                        },
                        new
                        {
                            StateId = 2,
                            Name = "Alaska"
                        },
                        new
                        {
                            StateId = 3,
                            Name = "Arizona"
                        },
                        new
                        {
                            StateId = 4,
                            Name = "Arkansas"
                        },
                        new
                        {
                            StateId = 5,
                            Name = "California"
                        },
                        new
                        {
                            StateId = 6,
                            Name = "Colorado"
                        },
                        new
                        {
                            StateId = 7,
                            Name = "Connecticut"
                        },
                        new
                        {
                            StateId = 8,
                            Name = "Delaware"
                        },
                        new
                        {
                            StateId = 9,
                            Name = "Florida"
                        },
                        new
                        {
                            StateId = 10,
                            Name = "Georgia"
                        },
                        new
                        {
                            StateId = 11,
                            Name = "Hawaii"
                        },
                        new
                        {
                            StateId = 12,
                            Name = "Idaho"
                        },
                        new
                        {
                            StateId = 13,
                            Name = "Illinois"
                        },
                        new
                        {
                            StateId = 14,
                            Name = "Indiana"
                        },
                        new
                        {
                            StateId = 15,
                            Name = "Iowa"
                        },
                        new
                        {
                            StateId = 16,
                            Name = "Kansas"
                        },
                        new
                        {
                            StateId = 17,
                            Name = "Kentucky"
                        },
                        new
                        {
                            StateId = 18,
                            Name = "Lousiana"
                        },
                        new
                        {
                            StateId = 19,
                            Name = "Maine"
                        },
                        new
                        {
                            StateId = 20,
                            Name = "Maryland"
                        },
                        new
                        {
                            StateId = 21,
                            Name = "Massachusetss"
                        },
                        new
                        {
                            StateId = 22,
                            Name = "Michigan"
                        },
                        new
                        {
                            StateId = 23,
                            Name = "Minnesota"
                        },
                        new
                        {
                            StateId = 24,
                            Name = "Mississippi"
                        },
                        new
                        {
                            StateId = 25,
                            Name = "Missouri"
                        },
                        new
                        {
                            StateId = 26,
                            Name = "Montana"
                        },
                        new
                        {
                            StateId = 27,
                            Name = "Nebraska"
                        },
                        new
                        {
                            StateId = 28,
                            Name = "Nevada"
                        },
                        new
                        {
                            StateId = 29,
                            Name = "New Hampshire"
                        },
                        new
                        {
                            StateId = 30,
                            Name = "New Jersey"
                        },
                        new
                        {
                            StateId = 31,
                            Name = "New Mexico"
                        },
                        new
                        {
                            StateId = 32,
                            Name = "New York"
                        },
                        new
                        {
                            StateId = 33,
                            Name = "North Carolina"
                        },
                        new
                        {
                            StateId = 34,
                            Name = "North Dakota"
                        },
                        new
                        {
                            StateId = 35,
                            Name = "Ohio"
                        },
                        new
                        {
                            StateId = 36,
                            Name = "Oklahoma"
                        },
                        new
                        {
                            StateId = 37,
                            Name = "Oregon"
                        },
                        new
                        {
                            StateId = 38,
                            Name = "Pennsylvania"
                        },
                        new
                        {
                            StateId = 39,
                            Name = "Rhode Island"
                        },
                        new
                        {
                            StateId = 40,
                            Name = "South Carolina"
                        },
                        new
                        {
                            StateId = 41,
                            Name = "South Dakota"
                        },
                        new
                        {
                            StateId = 42,
                            Name = "Tennessee"
                        },
                        new
                        {
                            StateId = 43,
                            Name = "Texas"
                        },
                        new
                        {
                            StateId = 44,
                            Name = "Utah"
                        },
                        new
                        {
                            StateId = 45,
                            Name = "Vermont"
                        },
                        new
                        {
                            StateId = 46,
                            Name = "Virginia"
                        },
                        new
                        {
                            StateId = 47,
                            Name = "Washington"
                        },
                        new
                        {
                            StateId = 48,
                            Name = "West Virginia"
                        },
                        new
                        {
                            StateId = 49,
                            Name = "Wisconsin"
                        },
                        new
                        {
                            StateId = 50,
                            Name = "Wyoming"
                        });
                });

            modelBuilder.Entity("NationalParksApi.NatlPark", b =>
                {
                    b.HasOne("NationalParksApi.State", null)
                        .WithMany("Parks")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("NationalParksApi.State", b =>
                {
                    b.Navigation("Parks");
                });
#pragma warning restore 612, 618
        }
    }
}
