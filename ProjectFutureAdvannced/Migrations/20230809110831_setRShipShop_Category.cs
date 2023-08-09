using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class setRShipShop_Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61f93599-69e2-496a-a21d-5275bb3e55c7");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9659cb3e-c44e-4748-9ab2-679afa87907f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f95be442-3b57-4d2b-bcf5-b063607caff5");

            migrationBuilder.AddColumn<int>(
                name: "CategoryName",
                table: "Shop",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Categories_Name",
                table: "Categories",
                column: "Name");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2cafb1b0-95f4-4d03-a3e4-fd06e11c1d61", null, "User", "USER" },
                    { "80daa54f-7ff5-4527-8efb-38f77aac4fb5", null, "Shop", "SHOP" },
                    { "9eaee098-162d-43ee-b0a0-a747de97d908", null, "Admin", "ADMIN" }
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

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Categories_Name",
                table: "Categories");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2cafb1b0-95f4-4d03-a3e4-fd06e11c1d61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80daa54f-7ff5-4527-8efb-38f77aac4fb5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9eaee098-162d-43ee-b0a0-a747de97d908");

            migrationBuilder.DropColumn(
                name: "CategoryName",
                table: "Shop");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "61f93599-69e2-496a-a21d-5275bb3e55c7", null, "User", "USER" },
                    { "9659cb3e-c44e-4748-9ab2-679afa87907f", null, "Admin", "ADMIN" },
                    { "f95be442-3b57-4d2b-bcf5-b063607caff5", null, "Shop", "SHOP" }
                });
        }
    }
}
