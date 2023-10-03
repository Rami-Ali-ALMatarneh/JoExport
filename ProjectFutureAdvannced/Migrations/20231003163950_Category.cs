using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "47c01018-5abb-4735-a943-72da03a0f9b7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8077c7fc-4022-4c82-beed-655a2f5c56e2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a3558098-68bc-42ec-9245-f3b76a020eab");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07435227-720e-4b41-9f81-9e6398d6462f", null, "User", "USER" },
                    { "16aac71c-c22f-45b3-bfd8-232a6a9e79a4", null, "Shop", "SHOP" },
                    { "d0815bb9-8426-4256-b7ea-02756d9df0e8", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07435227-720e-4b41-9f81-9e6398d6462f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "16aac71c-c22f-45b3-bfd8-232a6a9e79a4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0815bb9-8426-4256-b7ea-02756d9df0e8");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "47c01018-5abb-4735-a943-72da03a0f9b7", null, "Admin", "ADMIN" },
                    { "8077c7fc-4022-4c82-beed-655a2f5c56e2", null, "Shop", "SHOP" },
                    { "a3558098-68bc-42ec-9245-f3b76a020eab", null, "User", "USER" }
                });
        }
    }
}
