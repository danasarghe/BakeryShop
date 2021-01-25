using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryShop.Migrations
{
    public partial class AddBreadUrl : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "https://www.flickr.com/photos/26546421@N05/10883843896/in/photostream/");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 3,
                column: "ImageThumbnailUrl",
                value: "https://drive.google.com/file/d/1SaJtODcKIclXRiRzufvnWTKaaXqmgH6f/view?usp=sharing");
        }
    }
}
