using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class SetSeedCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "045147a4-74f5-4795-b3df-131b9cffd45f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98f8658d-6407-4d8b-bc6c-922df358b51d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0456ac4-bc06-4b19-8cc5-ccb86ebe01b3");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14ec786b-ba03-42e9-83ef-3d31704170c4", null, "User", "USER" },
                    { "6d339b0b-4981-4658-ab96-49a948220612", null, "Admin", "ADMIN" },
                    { "feda708d-d335-48b7-95aa-4bc10990b2cb", null, "Shop", "SHOP" }
                });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "Id", "CategoryImg", "Name" },
                values: new object[,]
                {
                    { 1, "cars.png", 2 },
                    { 2, "Electronic.png", 1 },
                    { 3, "home.png", 0 },
                    { 4, "Baby.png", 7 },
                    { 5, "Beauty.png", 6 },
                    { 6, "Clothes.png", 5 },
                    { 7, "Bags.png", 11 },
                    { 8, "Books.png", 9 },
                    { 9, "Health.png", 3 },
                    { 10, "Jewelry.png", 10 },
                    { 11, "pets.png", 8 },
                    { 12, "Sport.png", 4 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "14ec786b-ba03-42e9-83ef-3d31704170c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d339b0b-4981-4658-ab96-49a948220612");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "feda708d-d335-48b7-95aa-4bc10990b2cb");

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "045147a4-74f5-4795-b3df-131b9cffd45f", null, "User", "USER" },
                    { "98f8658d-6407-4d8b-bc6c-922df358b51d", null, "Admin", "ADMIN" },
                    { "e0456ac4-bc06-4b19-8cc5-ccb86ebe01b3", null, "Shop", "SHOP" }
                });
        }
    }
}
