using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class setTypeOfUserEnums : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shop_Categories_CategoryName",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Shop_CategoryName",
                table: "Shop");

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

            migrationBuilder.AlterColumn<int>(
                name: "TypeOfRoles",
                table: "User",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "TypeOfRoles",
                table: "Shop",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryName",
                table: "Shop",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "TypeOfRoles",
                table: "Admin",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "231d5399-7e47-492b-832b-a6aa457d3f61", null, "User", "USER" },
                    { "3844b5cb-016a-4f16-bef3-b6d889c205cf", null, "Admin", "ADMIN" },
                    { "529ebbf2-b720-40a6-81c2-5a2c2be46504", null, "Shop", "SHOP" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shop_CategoryName",
                table: "Shop",
                column: "CategoryName",
                unique: true,
                filter: "[CategoryName] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_Categories_CategoryName",
                table: "Shop",
                column: "CategoryName",
                principalTable: "Categories",
                principalColumn: "Name");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Shop_Categories_CategoryName",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Shop_CategoryName",
                table: "Shop");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "231d5399-7e47-492b-832b-a6aa457d3f61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3844b5cb-016a-4f16-bef3-b6d889c205cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "529ebbf2-b720-40a6-81c2-5a2c2be46504");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfRoles",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfRoles",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryName",
                table: "Shop",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfRoles",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "e08757cf-8133-408b-ae2a-c1671ab496a6", null, "Admin", "ADMIN" },
                    { "e0a84227-4799-4dc8-aea3-3df627131c44", null, "Shop", "SHOP" },
                    { "ec958ddc-47b0-4965-97d6-a050afac8e1b", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Shop_CategoryName",
                table: "Shop",
                column: "CategoryName",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_Categories_CategoryName",
                table: "Shop",
                column: "CategoryName",
                principalTable: "Categories",
                principalColumn: "Name",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
