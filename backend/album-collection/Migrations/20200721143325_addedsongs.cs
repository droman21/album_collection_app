using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class addedsongs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Songs",
                columns: table => new
                {
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    AlbumID = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Songs", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Songs_Albums_AlbumID",
                        column: x => x.AlbumID,
                        principalTable: "Albums",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Songs",
                columns: new[] { "ID", "AlbumID", "Name" },
                values: new object[,]
                {
                    { 1, 1, "Death in my pocket" },
                    { 18, 9, "Super Song" },
                    { 17, 9, "Holiday" },
                    { 16, 8, "Super Song" },
                    { 15, 8, "Legend" },
                    { 14, 7, "Super Song" },
                    { 13, 7, "Hype" },
                    { 12, 6, "Super Song" },
                    { 11, 6, "Bad Guy" },
                    { 10, 5, "Super Song" },
                    { 9, 5, "My Boy" },
                    { 8, 4, "Super Song" },
                    { 7, 4, "Hold Up" },
                    { 6, 3, "Super Song" },
                    { 5, 3, "Free Lunch" },
                    { 4, 2, "Super Song" },
                    { 3, 2, "Clusters" },
                    { 2, 1, "Super Song" },
                    { 19, 10, "West Savannah" },
                    { 20, 10, "Super Song" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Songs_AlbumID",
                table: "Songs",
                column: "AlbumID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Songs");
        }
    }
}
