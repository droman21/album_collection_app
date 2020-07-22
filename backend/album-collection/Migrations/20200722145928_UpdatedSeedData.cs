using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class UpdatedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "HotelDiablo.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "EatOrGetAte.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "Lemonade.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "MGK.jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "BigMoochie.jpg");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "MGK.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "BigMoochie.jpg");

            migrationBuilder.UpdateData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 4,
                column: "Image",
                value: "Lemonade. jpg");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 1,
                column: "Image",
                value: "Image");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 2,
                column: "Image",
                value: "Image");
        }
    }
}
