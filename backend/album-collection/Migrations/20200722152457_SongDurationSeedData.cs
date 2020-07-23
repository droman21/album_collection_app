using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class SongDurationSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "SongDuration",
                table: "Songs",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 1,
                column: "SongDuration",
                value: "2:37");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 2,
                column: "SongDuration",
                value: "4:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 3,
                column: "SongDuration",
                value: "5:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 4,
                column: "SongDuration",
                value: "1:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 5,
                column: "SongDuration",
                value: "6:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 6,
                column: "SongDuration",
                value: "3:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 7,
                column: "SongDuration",
                value: "5:37");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 8,
                column: "SongDuration",
                value: "4:24");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 9,
                column: "SongDuration",
                value: "4:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 10,
                column: "SongDuration",
                value: "4:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 11,
                column: "SongDuration",
                value: "4:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 12,
                column: "SongDuration",
                value: "4:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 13,
                column: "SongDuration",
                value: "4:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 14,
                column: "SongDuration",
                value: "4:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 15,
                column: "SongDuration",
                value: "4:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 16,
                column: "SongDuration",
                value: "4:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 17,
                column: "SongDuration",
                value: "4:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 18,
                column: "SongDuration",
                value: "4:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 19,
                column: "SongDuration",
                value: "4:34");

            migrationBuilder.UpdateData(
                table: "Songs",
                keyColumn: "ID",
                keyValue: 20,
                column: "SongDuration",
                value: "4:34");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "SongDuration",
                table: "Songs");
        }
    }
}
