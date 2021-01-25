using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryShop.Migrations
{
    public partial class AddBreadName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 3,
                column: "Name",
                value: "Paine integrala");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 8,
                column: "Name",
                value: "Pâine integrală cu seminţe de dovleac");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 3,
                column: "Name",
                value: "Paine integrala de grau");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 8,
                column: "Name",
                value: "Pâine integrală de grâu şi seminţe de dovleac");
        }
    }
}
