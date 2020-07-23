using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Artists",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArtistName = table.Column<string>(nullable: true),
                    Image = table.Column<string>(nullable: true),
                    Age = table.Column<int>(nullable: false),
                    RecordLabel = table.Column<string>(nullable: true),
                    HomeTown = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artists", x => x.ID);
                });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ID", "Age", "ArtistName", "HomeTown", "Image", "RecordLabel" },
                values: new object[] { 1, 30, "Machine Gun Kelly", "Cleveland, OH", "Image", "Cleveland Record Label" });

            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ID", "Age", "ArtistName", "HomeTown", "Image", "RecordLabel" },
                values: new object[] { 2, 29, "Big Moochie Grape", "Memphis, TN", "Image", "Paper Route EMPIRE" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Artists");
        }
    }
}
