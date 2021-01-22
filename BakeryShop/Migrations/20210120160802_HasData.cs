using Microsoft.EntityFrameworkCore.Migrations;

namespace BakeryShop.Migrations
{
    public partial class HasData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "ShortDescription", "TypeOfBread" },
                values: new object[] { 1, "Special Bread", null, 0 });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "ShortDescription", "TypeOfBread" },
                values: new object[] { 2, "Regular Bread", null, 0 });

            migrationBuilder.InsertData(
                table: "Breads",
                columns: new[] { "BreadId", "CategoryId", "Description", "Image", "ImageThumbnail", "Name", "Price" },
                values: new object[,]
                {
                    { 2, 1, "Faina alba de grau,Faina spelta, apa, sare, 5% maia naturala din faina de grau, 600 g.", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21325&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21325&parId=880317F0636F898D%21316&o=OneUp", "Spelt Bread", 12m },
                    { 5, 1, "Se spune că simplitatea este cea mai înalta formă a sofisticării, iar această pâine susţine această afirmaţie în mod categoric. Gustul bogat si simplu o face extrem de versatilă pentru toate ideile de masă.", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21323&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21323&parId=880317F0636F898D%21316&o=OneUp", "Leaven Bread", 13m },
                    { 6, 1, "Baghetă tradițională franţuzească, cu miez puţin, alveolat şi o crustă crocantă şi subţire. Alegerea perfectă pentru toate mesele.", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21330&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21330&parId=880317F0636F898D%21316&o=OneUp", "Baquette Bread", 6.5m },
                    { 7, 1, "O pâine moale şi fină, de inspiraţie italienească, conţine ulei de măsline extravirgin din belşug, contribuind decisiv la gustul agreabil.", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21329&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21329&parId=880317F0636F898D%21316&o=OneUp", "Ciabata Bread", 13m },
                    { 1, 2, "100% faina alba de grau, apa, sare, 5% maia naturala din faina de grau, 600 g.", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21317&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21317&parId=880317F0636F898D%21316&o=OneUp", "White Bread", 10m },
                    { 3, 2, "Prin faina 100% integrala din care este dospita, aceasta paine aduce numeroase beneficii sanatatii: regleaza tranzitul intestinal datorita cantitatii ridicate de fibre, are indice glicemic scazut, fiind astfel potrivita si pentru diabetici, contine o multitudine de vitamine, precum B1, B2, B3, B5 si ofera senzatia de satietate pe termen lung", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21320&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21320&parId=880317F0636F898D%21316&o=OneUp", "Whole Weat Bread", 11m },
                    { 4, 2, "Paine intermediara cu maia naturala, fara drojdie si fara aditivi. Incearca si tu savuroasa paine rustica ", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21318&parId=880317F0636F898D%21316&o=OneUp", "https://onedrive.live.com/?cid=880317F0636F898D&id=880317F0636F898D%21318&parId=880317F0636F898D%21316&o=OneUp", "Rustic Bread", 12m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Breads",
                keyColumn: "BreadId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);
        }
    }
}
