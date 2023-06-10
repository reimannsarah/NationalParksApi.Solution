using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NationalParksApi.Migrations
{
    public partial class SeedDatabaseWithSomeNationalParks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "NatlParks",
                columns: new[] { "NatlParkId", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Features the tallest mountain on the Atlantic Coast of the United States.", "Acadia" },
                    { 2, "Features more than 2,000 natural sanstone arches.", "Arches" },
                    { 3, "Collection of buttes, pinnacles, spires, and mixed grass prairies.", "Badlands" },
                    { 4, "Named for the prominent bend in the Rio Grande along the U.S. -- Mexico border.", "Big Bend" },
                    { 5, "Mostly underwater park at the north end of the Florida Keys.", "Biscayne" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 5);
        }
    }
}
