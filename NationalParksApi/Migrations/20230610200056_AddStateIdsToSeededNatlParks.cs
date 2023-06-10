using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NationalParksApi.Migrations
{
    public partial class AddStateIdsToSeededNatlParks : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 1,
                column: "StateId",
                value: 19);

            migrationBuilder.UpdateData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 2,
                column: "StateId",
                value: 44);

            migrationBuilder.UpdateData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 3,
                column: "StateId",
                value: 41);

            migrationBuilder.UpdateData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 4,
                column: "StateId",
                value: 43);

            migrationBuilder.UpdateData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 5,
                column: "StateId",
                value: 9);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 1,
                column: "StateId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 2,
                column: "StateId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 3,
                column: "StateId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 4,
                column: "StateId",
                value: 0);

            migrationBuilder.UpdateData(
                table: "NatlParks",
                keyColumn: "NatlParkId",
                keyValue: 5,
                column: "StateId",
                value: 0);
        }
    }
}
