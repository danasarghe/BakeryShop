using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryShop.Migrations
{
    public partial class ImageWhite : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://1drv.ms/u/s!Ao2Jb2PwFwOIgkf1q48zFOCIIkhF", "https://1drv.ms/u/s!Ao2Jb2PwFwOIgkf1q48zFOCIIkhF" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg" });
        }
    }
}
