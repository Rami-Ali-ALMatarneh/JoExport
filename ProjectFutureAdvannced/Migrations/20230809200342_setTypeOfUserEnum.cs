using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class setTypeOfUserEnum : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a790b41f-98ce-4dcd-b765-62fd963af4b0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3312af6-ebbb-43d7-b9a6-f632212ed21d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e019e359-8013-4129-b20d-bf93be6d2e41");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfRoles",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfRoles",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e08757cf-8133-408b-ae2a-c1671ab496a6", null, "Admin", "ADMIN" },
                    { "e0a84227-4799-4dc8-aea3-3df627131c44", null, "Shop", "SHOP" },
                    { "ec958ddc-47b0-4965-97d6-a050afac8e1b", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e08757cf-8133-408b-ae2a-c1671ab496a6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0a84227-4799-4dc8-aea3-3df627131c44");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ec958ddc-47b0-4965-97d6-a050afac8e1b");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfRoles",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfRoles",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a790b41f-98ce-4dcd-b765-62fd963af4b0", null, "Shop", "SHOP" },
                    { "c3312af6-ebbb-43d7-b9a6-f632212ed21d", null, "User", "USER" },
                    { "e019e359-8013-4129-b20d-bf93be6d2e41", null, "Admin", "ADMIN" }
                });
        }
    }
}
