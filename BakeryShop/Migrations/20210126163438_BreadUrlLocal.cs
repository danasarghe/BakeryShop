using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryShop.Migrations
{
    public partial class BreadUrlLocal : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "", "" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 2,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:5001/Images/White.png", "https://localhost:5001/Images/White.png" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 3,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:5001/Images/Paine-integrala.png", "https://localhost:5001/Images/Paine-integrala.png" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 4,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:5001/Images/rustica.jpg", "https://localhost:5001/Images/rustica.jpg" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 5,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:5001/Images/leaven.png", "https://localhost:5001/Images/leaven.png" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 6,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:5001/Images/French-baguette.jpg", "https://localhost:5001/Images/French-baguette.jpg" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 7,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:5001/Images/ciabatta.jpg", "https://localhost:5001/Images/ciabatta.jpg" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:5001/Images/integralaSeminte.png", "https://localhost:5001/Images/integralaSeminte.png" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:5001/Images/round.jpg", "https://localhost:5001/Images/round.jpg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 8,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://localhost:5001/Images/bread.jpg", "https://localhost:5001/Images/bread.jpg" });

            migrationBuilder.UpdateData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 9,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://drive.google.com/file/d/1L1QCsR1YOoraTcz7hrh1qnvvxisQB_sc/view?usp=sharing", "https://drive.google.com/file/d/1L1QCsR1YOoraTcz7hrh1qnvvxisQB_sc/view?usp=sharing" });
        }
    }
}
