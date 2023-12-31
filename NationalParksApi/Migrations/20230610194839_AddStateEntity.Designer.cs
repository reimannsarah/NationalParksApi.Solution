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
    [Migration("20230610194839_AddStateEntity")]
    partial class AddStateEntity
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

                    b.HasKey("NatlParkId");

                    b.ToTable("NatlParks");

                    b.HasData(
                        new
                        {
                            NatlParkId = 1,
                            Description = "Features the tallest mountain on the Atlantic Coast of the United States.",
                            Name = "Acadia"
                        },
                        new
                        {
                            NatlParkId = 2,
                            Description = "Features more than 2,000 natural sanstone arches.",
                            Name = "Arches"
                        },
                        new
                        {
                            NatlParkId = 3,
                            Description = "Collection of buttes, pinnacles, spires, and mixed grass prairies.",
                            Name = "Badlands"
                        },
                        new
                        {
                            NatlParkId = 4,
                            Description = "Named for the prominent bend in the Rio Grande along the U.S. -- Mexico border.",
                            Name = "Big Bend"
                        },
                        new
                        {
                            NatlParkId = 5,
                            Description = "Mostly underwater park at the north end of the Florida Keys.",
                            Name = "Biscayne"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
