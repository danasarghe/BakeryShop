using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryShop.Migrations
{
    public partial class ImageBaquette : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://1drv.ms/u/s!Ao2Jb2PwFwOIgkrbq4w-CE0v0E-t", "https://1drv.ms/u/s!Ao2Jb2PwFwOIgkrbq4w-CE0v0E-t" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21330&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21330&parId=880317F0636F898D%21316&o=OneUp" });
        }
    }
}
