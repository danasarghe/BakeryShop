using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryShop.Migrations
{
    public partial class ImageLink : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://drive.google.com/file/d/1MFmOehz-SZVzCcIR515MaNwNLdzQFNLp/view?usp=sharing", "https://drive.google.com/file/d/1MFmOehz-SZVzCcIR515MaNwNLdzQFNLp/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://drive.google.com/file/d/1xJPc2Zj4MqpqWZ_7y2PC0EgZ7Hc74U2L/view?usp=sharing", "https://drive.google.com/file/d/1xJPc2Zj4MqpqWZ_7y2PC0EgZ7Hc74U2L/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://drive.google.com/file/d/1SaJtODcKIclXRiRzufvnWTKaaXqmgH6f/view?usp=sharing", "https://drive.google.com/file/d/1SaJtODcKIclXRiRzufvnWTKaaXqmgH6f/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://drive.google.com/file/d/1LKKPFswosygLv_HS5_zhnLkVzAmtSv6f/view?usp=sharing", "https://drive.google.com/file/d/1LKKPFswosygLv_HS5_zhnLkVzAmtSv6f/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://drive.google.com/file/d/1HvwU6ZQf5rsAPYBPprqNgDHKqksxvqZF/view?usp=sharing", "https://drive.google.com/file/d/1HvwU6ZQf5rsAPYBPprqNgDHKqksxvqZF/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://drive.google.com/file/d/1vh-X6_ETQYgdb-zUA0JSUpzYYdXO-w0u/view?usp=sharing", "https://drive.google.com/file/d/1vh-X6_ETQYgdb-zUA0JSUpzYYdXO-w0u/view?usp=sharing" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://drive.google.com/file/d/1ZJPjA3tneKXqncoAXpmD63L35ybRaJ8D/view?usp=sharing", "https://drive.google.com/file/d/1ZJPjA3tneKXqncoAXpmD63L35ybRaJ8D/view?usp=sharing" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://pin.it/5YVQuYq", "https://pin.it/5YVQuYq" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21325&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21325&parId=880317F0636F898D%21316&o=OneUp" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21320&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21320&parId=880317F0636F898D%21316&o=OneUp" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21318&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21318&parId=880317F0636F898D%21316&o=OneUp" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21323&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21323&parId=880317F0636F898D%21316&o=OneUp" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://1drv.ms/u/s!Ao2Jb2PwFwOIgkrbq4w-CE0v0E-t", "https://1drv.ms/u/s!Ao2Jb2PwFwOIgkrbq4w-CE0v0E-t" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21329&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21329&parId=880317F0636F898D%21316&o=OneUp" });
        }
    }
}
