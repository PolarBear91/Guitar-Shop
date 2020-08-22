using Microsoft.EntityFrameworkCore.Migrations;

namespace Data_Access_Layer.Migrations
{
    public partial class AddedNewProductVer3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Guitars",
                columns: new[] { "GuitarId", "Brand", "CategoryId", "DescriptionOfGuitar", "ImageThumbnailUrl", "ImageUrl", "InStock", "IsGuitarOfTheWeek", "Model", "Price" },
                values: new object[] { 2, "Gibson", 1, "LP", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepiesmall.jpg", "https://gillcleerenpluralsight.blob.core.windows.net/files/applepie.jpg", true, true, null, 25.95m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Guitars",
                keyColumn: "GuitarId",
                keyValue: 2);
        }
    }
}
