using Microsoft.EntityFrameworkCore.Migrations;

namespace album_collection.Migrations
{
    public partial class AddedSeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Artists",
                columns: new[] { "ID", "Age", "ArtistName", "HomeTown", "Image", "RecordLabel" },
                values: new object[,]
                {
                    { 3, 29, "Isaiah Rashad", "Chattanooga, TN", "IsaiahRashad.jpg", "Top Dawg Entertainment" },
                    { 4, 38, "Beyonce", "Houston, TX", "Beyonce.jpg", "Parkwood" },
                    { 5, 18, "Billie Eilish", "Los Angeles, CA", "BillieEilish.jpg", "Interscope Records" },
                    { 6, 33, "Drake", "Toronto, Canada", "Drake.jpg", "OVO Sound" }
                });

            migrationBuilder.InsertData(
                table: "Albums",
                columns: new[] { "ID", "ArtistID", "Image", "Label", "Title" },
                values: new object[,]
                {
                    { 3, 3, "SunsTirade.jpg", "Top Dawg Entertainment", "The Sun's Tirade" },
                    { 10, 3, "CilviaDemo.jpg", "Top Dawg Entertainment", "Cilvia Demo" },
                    { 4, 4, "Lemonade. jpg", "Parkwood", "Lemonade" },
                    { 5, 5, "DontSmileAtMe.jpg", "Interscope Records", "Don't Smile At Me" },
                    { 6, 5, "wwafawdwg.jpg", "Interscope Records", "When We All Fall Aleep, Where Do We Go?" },
                    { 7, 6, "Views.jpg", "OVO Sound", "Views" },
                    { 8, 6, "iyrtitl.jpg", "OVO Sound", "If You're Reading This It's Too Late" },
                    { 9, 6, "Scorpion.jpg", "OVO Sound", "Scorpion" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Albums",
                keyColumn: "ID",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Artists",
                keyColumn: "ID",
                keyValue: 6);
        }
    }
}
