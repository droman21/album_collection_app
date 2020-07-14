using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class AlbumMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Albums",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistID = table.Column<int>(nullable: false),
                    Title = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Label = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albums", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Albums_Artists_ArtistID",
                        column: x => x.ArtistID,
                        principalTable: "Artists",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "ArtistID", "Image", "Label", "Title" },
                values: new object[] { 1, 1, "MGK.jpg", "Bad Boy Records", "Hotel Diablo" });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "ArtistID", "Image", "Label", "Title" },
                values: new object[] { 2, 2, "BigMoochie.jpg", "Paper Route Empire", "Eat or Get Ate" });

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 1,
                column: "RecordLabel",
                value: "Bad Boy Records");

            migrationBuilder.CreateIndex(
                name: "IX_Albums_ArtistID",
                table: "Albums",
                column: "ArtistID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Albums");

            migrationBuilder.UpdateData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 1,
                column: "RecordLabel",
                value: "Cleveland Record Label");
        }
    }
}
