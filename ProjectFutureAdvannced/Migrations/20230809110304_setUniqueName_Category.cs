using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class setUniqueName_Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0b1018f2-d75c-4b08-905b-95dd8c937469");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3fdecfe9-0643-4f45-b990-8f1cba37530f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f4b8d4ce-ebc7-46e2-b450-901c98b25137");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61f93599-69e2-496a-a21d-5275bb3e55c7", null, "User", "USER" },
                    { "9659cb3e-c44e-4748-9ab2-679afa87907f", null, "Admin", "ADMIN" },
                    { "f95be442-3b57-4d2b-bcf5-b063607caff5", null, "Shop", "SHOP" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Categories_Name",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61f93599-69e2-496a-a21d-5275bb3e55c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9659cb3e-c44e-4748-9ab2-679afa87907f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f95be442-3b57-4d2b-bcf5-b063607caff5");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0b1018f2-d75c-4b08-905b-95dd8c937469", null, "Shop", "SHOP" },
                    { "3fdecfe9-0643-4f45-b990-8f1cba37530f", null, "Admin", "ADMIN" },
                    { "f4b8d4ce-ebc7-46e2-b450-901c98b25137", null, "User", "USER" }
                });
        }
    }
}
