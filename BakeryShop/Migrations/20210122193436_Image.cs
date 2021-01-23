using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryShop.Migrations
{
    public partial class Image : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21317&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21317&parId=880317F0636F898D%21316&o=OneUp" });
        }
    }
}
