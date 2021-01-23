using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryShop.Migrations
{
    public partial class AnotherChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 5,
                column: "Description",
                value: "Se spune că simplitatea este cea mai înalta formă a sofisticării, iar această pâine susţine această afirmaţie în mod categoric.");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 5,
                column: "Description",
                value: "Se spune că simplitatea este cea mai înalta formă a sofisticării, iar această pâine susţine această afirmaţie în mod categoric. Gustul bogat si simplu o face extrem de versatilă pentru toate ideile de masă.");
        }
    }
}
