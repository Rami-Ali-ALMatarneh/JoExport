using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class _20230810205501_AddNewColminInIdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c6e856c-a728-4379-8725-d257c7e6ad39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a424a953-6a41-4743-b73f-078083fc413d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6590a23-f7a5-49b4-a882-b57e390daf12");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "AspNetUsers",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4f3f59f4-10ae-45d3-9815-0060a4d793d6", null, "Admin", "ADMIN" },
                    { "5c8f62d8-123c-40ba-a537-4c18687e8e7c", null, "Shop", "SHOP" },
                    { "d37635e7-a1a1-4108-9110-01aa8ee092a0", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4f3f59f4-10ae-45d3-9815-0060a4d793d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c8f62d8-123c-40ba-a537-4c18687e8e7c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d37635e7-a1a1-4108-9110-01aa8ee092a0");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7c6e856c-a728-4379-8725-d257c7e6ad39", null, "Admin", "ADMIN" },
                    { "a424a953-6a41-4743-b73f-078083fc413d", null, "Shop", "SHOP" },
                    { "f6590a23-f7a5-49b4-a882-b57e390daf12", null, "User", "USER" }
                });
        }
    }
}
