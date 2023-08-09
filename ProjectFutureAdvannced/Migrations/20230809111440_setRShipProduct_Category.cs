using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class setRShipProduct_Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<int>(
                name: "CategoryId",
                table: "products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "12a2fa03-ee84-423d-bb28-dc1cd65428c2", null, "User", "USER" },
                    { "622d6941-09b8-4d45-8eea-f3f6966ccb22", null, "Shop", "SHOP" },
                    { "873820f8-d537-4e63-a16b-36aa83ccfea0", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_products_CategoryId",
                table: "products",
                column: "CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_products_Categories_CategoryId",
                table: "products",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_products_Categories_CategoryId",
                table: "products");

            migrationBuilder.DropIndex(
                name: "IX_products_CategoryId",
                table: "products");

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

            migrationBuilder.DropColumn(
                name: "CategoryId",
                table: "products");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2cafb1b0-95f4-4d03-a3e4-fd06e11c1d61", null, "User", "USER" },
                    { "80daa54f-7ff5-4527-8efb-38f77aac4fb5", null, "Shop", "SHOP" },
                    { "9eaee098-162d-43ee-b0a0-a747de97d908", null, "Admin", "ADMIN" }
                });
        }
    }
}
