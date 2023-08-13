using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class AddNewColumnInAdmin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<DateTime>(
                name: "Birthday",
                table: "Admin",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Gender",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "PhoneNumber",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "62e2c816-fd31-4d7d-a6bd-b24379f082d1", null, "Shop", "SHOP" },
                    { "7493a761-289c-4522-825e-8e9a9b151a48", null, "User", "USER" },
                    { "a1a42ff6-959e-412e-89f6-1778d9cf70e5", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "62e2c816-fd31-4d7d-a6bd-b24379f082d1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7493a761-289c-4522-825e-8e9a9b151a48");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1a42ff6-959e-412e-89f6-1778d9cf70e5");

            migrationBuilder.DropColumn(
                name: "Birthday",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "PhoneNumber",
                table: "Admin");

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
    }
}
