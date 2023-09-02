using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class CreateWishListTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "43e278c1-9952-4099-a3bb-d5af8890e44f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e4a8715e-52cd-48e2-b089-40aa38fb874f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ed6e76e2-b4c7-4c04-9bfb-ac67024a67ef");

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "posts",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.CreateTable(
                name: "Wishlists",
                columns: table => new
                {
                    UserId = table.Column<int>(type: "int", nullable: false),
                    ProductId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Wishlists", x => new { x.UserId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_Wishlists_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Wishlists_products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "0771ed09-5eff-4817-be87-4d7562057d99", null, "Admin", "ADMIN" },
                    { "9e3da820-b5d6-42bc-96bd-a1eb7c24956d", null, "Shop", "SHOP" },
                    { "eb1049bc-00d4-472f-8764-1f2a496e73fb", null, "User", "USER" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Wishlists_ProductId",
                table: "Wishlists",
                column: "ProductId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Wishlists");

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

            migrationBuilder.AlterColumn<string>(
                name: "ImageUrl",
                table: "posts",
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
                    { "43e278c1-9952-4099-a3bb-d5af8890e44f", null, "Shop", "SHOP" },
                    { "e4a8715e-52cd-48e2-b089-40aa38fb874f", null, "Admin", "ADMIN" },
                    { "ed6e76e2-b4c7-4c04-9bfb-ac67024a67ef", null, "User", "USER" }
                });
        }
    }
}
