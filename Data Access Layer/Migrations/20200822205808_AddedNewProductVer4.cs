using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Access_Layer.Migrations
{
    public partial class AddedNewProductVer4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "~/Images/Guitars/Ibanez bass.JPG", "~/Images/Guitars/Ibanez bass.JPG" });

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 2,
                columns: new[] { "DescriptionOfGuitar", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "Les Paul classic", "Images/Guitars/Ibanez bass.JPG", "Images/Guitars/Ibanez bass.JPG" });

            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "GuitarId", "Brand", "CategoryId", "DescriptionOfGuitar", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsGuitarOfTheWeek", "Model", "Price" },
                values: new object[,]
                {
                    { 56, "Gibson", 1, "Les Paul classic", "Images/Guitars/Ibanez bass.JPG", "Images/Guitars/Ibanez bass.JPG", true, true, null, 25.95m },
                    { 57, "Gibson sdfds", 1, "Les Paul classic", "~/Images/Guitars/Ibanez bass.JPG", "~/Images/Guitars/Ibanez bass.JPG", true, true, null, 25.95m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 57);

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 1,
                columns: new[] { "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg" });

            migrationBuilder.UpdateData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 2,
                columns: new[] { "DescriptionOfGuitar", "ImageThumbnailUrl", "ImageUrl" },
                values: new object[] { "LP", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg" });
        }
    }
}
