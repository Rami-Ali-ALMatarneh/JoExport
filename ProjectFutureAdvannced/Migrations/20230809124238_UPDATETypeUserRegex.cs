using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class UPDATETypeUserRegex : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a539899f-f936-4614-a367-b2873f4cad14", null, "User", "USER" },
                    { "af6dd5e8-5afb-457f-b72a-8f43632fb2ec", null, "Admin", "ADMIN" },
                    { "f8489caa-1302-4172-956a-28329585c575", null, "Shop", "SHOP" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a539899f-f936-4614-a367-b2873f4cad14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af6dd5e8-5afb-457f-b72a-8f43632fb2ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8489caa-1302-4172-956a-28329585c575");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "14ec786b-ba03-42e9-83ef-3d31704170c4", null, "User", "USER" },
                    { "6d339b0b-4981-4658-ab96-49a948220612", null, "Admin", "ADMIN" },
                    { "feda708d-d335-48b7-95aa-4bc10990b2cb", null, "Shop", "SHOP" }
                });
        }
    }
}
