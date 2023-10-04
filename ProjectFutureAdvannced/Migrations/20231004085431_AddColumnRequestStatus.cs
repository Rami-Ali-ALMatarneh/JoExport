using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class AddColumnRequestStatus : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3d3ce25a-9f37-45ef-a40c-dbf3cab3b220");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4fe4bba8-a582-4c1c-bf0a-7720bf3e2529");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cb428986-9858-40a2-80d1-76a51a9e035f");

            migrationBuilder.AddColumn<int>(
                name: "RequestStatus",
                table: "Shop",
                type: "int",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "58f5aee5-476d-40f2-91ba-553749d6bd93", null, "Admin", "ADMIN" },
                    { "89414c02-e42d-4c1f-88b5-d8f8fedc821a", null, "User", "USER" },
                    { "dc001e54-ac7d-4291-8180-2b2ab40c5d10", null, "Shop", "SHOP" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "58f5aee5-476d-40f2-91ba-553749d6bd93");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "89414c02-e42d-4c1f-88b5-d8f8fedc821a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "dc001e54-ac7d-4291-8180-2b2ab40c5d10");

            migrationBuilder.DropColumn(
                name: "RequestStatus",
                table: "Shop");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "3d3ce25a-9f37-45ef-a40c-dbf3cab3b220", null, "Admin", "ADMIN" },
                    { "4fe4bba8-a582-4c1c-bf0a-7720bf3e2529", null, "Shop", "SHOP" },
                    { "cb428986-9858-40a2-80d1-76a51a9e035f", null, "User", "USER" }
                });
        }
    }
}
