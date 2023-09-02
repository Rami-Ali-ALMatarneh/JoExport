using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class CascadeCardWishlist : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_products_ProductId",
                table: "Card");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlists_products_ProductId",
                table: "Wishlists");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0771ed09-5eff-4817-be87-4d7562057d99");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9e3da820-b5d6-42bc-96bd-a1eb7c24956d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "eb1049bc-00d4-472f-8764-1f2a496e73fb");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "9f0c4ec7-c721-4450-a742-b9fd975bafe0", null, "User", "USER" },
                    { "b6783505-4876-4177-92da-21f575f42856", null, "Shop", "SHOP" },
                    { "b97d1719-d3e0-474b-a5f5-749c6139fde2", null, "Admin", "ADMIN" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Card_products_ProductId",
                table: "Card",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlists_products_ProductId",
                table: "Wishlists",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_products_ProductId",
                table: "Card");

            migrationBuilder.DropForeignKey(
                name: "FK_Wishlists_products_ProductId",
                table: "Wishlists");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9f0c4ec7-c721-4450-a742-b9fd975bafe0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6783505-4876-4177-92da-21f575f42856");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b97d1719-d3e0-474b-a5f5-749c6139fde2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0771ed09-5eff-4817-be87-4d7562057d99", null, "Admin", "ADMIN" },
                    { "9e3da820-b5d6-42bc-96bd-a1eb7c24956d", null, "Shop", "SHOP" },
                    { "eb1049bc-00d4-472f-8764-1f2a496e73fb", null, "User", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Card_products_ProductId",
                table: "Card",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Wishlists_products_ProductId",
                table: "Wishlists",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
