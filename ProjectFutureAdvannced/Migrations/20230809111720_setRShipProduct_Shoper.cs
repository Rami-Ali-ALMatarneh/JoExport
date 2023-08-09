using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class setRShipProduct_Shoper : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "12a2fa03-ee84-423d-bb28-dc1cd65428c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "622d6941-09b8-4d45-8eea-f3f6966ccb22");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "873820f8-d537-4e63-a16b-36aa83ccfea0");

            migrationBuilder.AddColumn<int>(
                name: "ShoperId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "045147a4-74f5-4795-b3df-131b9cffd45f", null, "User", "USER" },
                    { "98f8658d-6407-4d8b-bc6c-922df358b51d", null, "Admin", "ADMIN" },
                    { "e0456ac4-bc06-4b19-8cc5-ccb86ebe01b3", null, "Shop", "SHOP" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_ShoperId",
                table: "products",
                column: "ShoperId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Shop_ShoperId",
                table: "products",
                column: "ShoperId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Shop_ShoperId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_ShoperId",
                table: "products");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "045147a4-74f5-4795-b3df-131b9cffd45f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "98f8658d-6407-4d8b-bc6c-922df358b51d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e0456ac4-bc06-4b19-8cc5-ccb86ebe01b3");

            migrationBuilder.DropColumn(
                name: "ShoperId",
                table: "products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12a2fa03-ee84-423d-bb28-dc1cd65428c2", null, "User", "USER" },
                    { "622d6941-09b8-4d45-8eea-f3f6966ccb22", null, "Shop", "SHOP" },
                    { "873820f8-d537-4e63-a16b-36aa83ccfea0", null, "Admin", "ADMIN" }
                });
        }
    }
}
