using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class updateDb1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2a141057-ed78-41fc-aaf5-3ba3ea4dbc53");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0c38ead-6301-453d-bbca-27567e404955");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "daea8928-7194-42bc-b21b-e5bc1490ba58");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Admin");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "af1449c9-4840-451a-92eb-41d4a2e5008c", null, "User", "USER" },
                    { "db72ef40-1858-4a03-9ff6-48a14cc812e8", null, "Admin", "ADMIN" },
                    { "f091176b-b9b8-4647-a49e-4a84a93f22f4", null, "Shop", "SHOP" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af1449c9-4840-451a-92eb-41d4a2e5008c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "db72ef40-1858-4a03-9ff6-48a14cc812e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f091176b-b9b8-4647-a49e-4a84a93f22f4");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2a141057-ed78-41fc-aaf5-3ba3ea4dbc53", null, "Admin", "ADMIN" },
                    { "d0c38ead-6301-453d-bbca-27567e404955", null, "User", "USER" },
                    { "daea8928-7194-42bc-b21b-e5bc1490ba58", null, "Shop", "SHOP" }
                });
        }
    }
}
