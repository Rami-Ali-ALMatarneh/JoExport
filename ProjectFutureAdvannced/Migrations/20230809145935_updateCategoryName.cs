using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class updateCategoryName : Migration
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
                keyValue: "8d00fb69-e7a7-4ad1-84b5-d7a569a3ee26");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9b7ac735-7894-452c-a742-10bffe1ea5b2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f6984a8-ccb1-4fc2-b2c5-3df521d9093d");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfRoles",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "CategoryName",
                table: "Shop",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a790b41f-98ce-4dcd-b765-62fd963af4b0", null, "Shop", "SHOP" },
                    { "c3312af6-ebbb-43d7-b9a6-f632212ed21d", null, "User", "USER" },
                    { "e019e359-8013-4129-b20d-bf93be6d2e41", null, "Admin", "ADMIN" }
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
                table: "Shop",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<int>(
                name: "CategoryName",
                table: "Shop",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8d00fb69-e7a7-4ad1-84b5-d7a569a3ee26", null, "Admin", "ADMIN" },
                    { "9b7ac735-7894-452c-a742-10bffe1ea5b2", null, "Shop", "SHOP" },
                    { "9f6984a8-ccb1-4fc2-b2c5-3df521d9093d", null, "User", "USER" }
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
    }
}
