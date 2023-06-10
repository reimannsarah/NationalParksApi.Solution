using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace NationalParksApi.Migrations
{
    public partial class AddListParksToStateEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_NatlParks_StateId",
                table: "NatlParks",
                column: "StateId");

            migrationBuilder.AddForeignKey(
                name: "FK_NatlParks_States_StateId",
                table: "NatlParks",
                column: "StateId",
                principalTable: "States",
                principalColumn: "StateId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_NatlParks_States_StateId",
                table: "NatlParks");

            migrationBuilder.DropIndex(
                name: "IX_NatlParks_StateId",
                table: "NatlParks");
        }
    }
}
