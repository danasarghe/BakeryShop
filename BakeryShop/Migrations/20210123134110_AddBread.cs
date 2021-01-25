using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryShop.Migrations
{
    public partial class AddBread : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 1,
                column: "Name",
                value: "Paine alba");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 2,
                column: "Name",
                value: "Paine cu faina spelta");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 3,
                column: "Name",
                value: "Paine integrala de grau");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 4,
                column: "Name",
                value: "Paine rustica");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 5,
                column: "Name",
                value: "Paine cu maia");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 6,
                column: "Name",
                value: "Paine Baquette");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 7,
                column: "Name",
                value: "Paine Ciabata");

            migrationBuilder.InsertData(
                table: "Breads",
                columns: new[] { "BreadId", "CategoryId", "Description", "ImageThumbnailUrl", "ImageUrl", "IsBreadOfTheWeek", "Name", "Price" },
                values: new object[,]
                {
                    { 8, 1, "O pâine foarte săţioasă şi hrănitoare, nu încetează să ne încânte prin profunzimea gustului şi textura complexă.", "https://drive.google.com/file/d/1xnbTQSSAVd_JaLvF2mtrf5aiR2RLc6Xf/view?usp=sharing", "https://drive.google.com/file/d/1xnbTQSSAVd_JaLvF2mtrf5aiR2RLc6Xf/view?usp=sharing", false, "Pâine integrală de grâu şi seminţe de dovleac", 14m },
                    { 9, 2, "Crusta este subţire şi gustoasă, iar miezul bogat, cu alveole mici şi regulate o fac o candidată perfectă pentru sandwichuri şi nu numai.", "https://drive.google.com/file/d/1L1QCsR1YOoraTcz7hrh1qnvvxisQB_sc/view?usp=sharing", "https://drive.google.com/file/d/1L1QCsR1YOoraTcz7hrh1qnvvxisQB_sc/view?usp=sharing", true, "Pâine intermediară", 11m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 9);

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 1,
                column: "Name",
                value: "White Bread");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 2,
                column: "Name",
                value: "Spelt Bread");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 3,
                column: "Name",
                value: "Whole Weat Bread");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 4,
                column: "Name",
                value: "Rustic Bread");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 5,
                column: "Name",
                value: "Leaven Bread");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 6,
                column: "Name",
                value: "Baquette Bread");

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 7,
                column: "Name",
                value: "Ciabata Bread");
        }
    }
}
