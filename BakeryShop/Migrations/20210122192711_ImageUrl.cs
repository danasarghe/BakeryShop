using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryShop.Migrations
{
    public partial class ImageUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageThumbnail",
                table: "Breads",
                newName: "ImageUrl");

            migrationBuilder.RenameColumn(
                name: "Image",
                table: "Breads",
                newName: "ImageThumbnailUrl");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ImageUrl",
                table: "Breads",
                newName: "ImageThumbnail");

            migrationBuilder.RenameColumn(
                name: "ImageThumbnailUrl",
                table: "Breads",
                newName: "Image");
        }
    }
}
