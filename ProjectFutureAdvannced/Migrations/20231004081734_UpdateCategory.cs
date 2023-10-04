using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCategory : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Categories_Name",
                table: "Categories");

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

            migrationBuilder.AlterColumn<string>(
                name: "CategoryName",
                table: "products",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "CategoryName",
                table: "products",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Categories",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07435227-720e-4b41-9f81-9e6398d6462f", null, "User", "USER" },
                    { "16aac71c-c22f-45b3-bfd8-232a6a9e79a4", null, "Shop", "SHOP" },
                    { "d0815bb9-8426-4256-b7ea-02756d9df0e8", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_Name",
                table: "Categories",
                column: "Name",
                unique: true);
        }
    }
}
