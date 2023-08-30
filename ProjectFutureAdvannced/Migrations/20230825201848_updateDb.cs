using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class updateDb : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "11ae75be-5dc1-41f5-80dd-b4be199a96e8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2204f0d5-80fd-4f6a-9fc3-be8a735a7bd4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e2ea261-41a5-498f-b157-82bf8e15942f");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "AspNetUsers",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                table: "AspNetUsers");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "11ae75be-5dc1-41f5-80dd-b4be199a96e8", null, "Shop", "SHOP" },
                    { "2204f0d5-80fd-4f6a-9fc3-be8a735a7bd4", null, "Admin", "ADMIN" },
                    { "5e2ea261-41a5-498f-b157-82bf8e15942f", null, "User", "USER" }
                });
        }
    }
}
