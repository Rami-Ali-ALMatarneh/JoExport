using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class UpdateCard : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Card",
                table: "Card");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1e09ebad-06a6-43b3-9b70-62fab5544fa9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "59155fdf-5402-49de-8a3c-62afb7360b17");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5f0b7ef5-c9bb-4116-80d5-4af56911f77f");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Card");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card",
                table: "Card",
                columns: new[] { "UserId", "ProductId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2bbaf133-ce2c-4b82-9faf-1bc8acce470c", null, "User", "USER" },
                    { "2e03212c-05d4-45c9-aa42-563d7a337a4e", null, "Admin", "ADMIN" },
                    { "6817b84a-c9b0-44e6-9d25-4736c6673565", null, "Shop", "SHOP" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Card_ProductId",
                table: "Card",
                column: "ProductId");

            migrationBuilder.AddForeignKey(
                name: "FK_Card_User_UserId",
                table: "Card",
                column: "UserId",
                principalTable: "User",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Card_products_ProductId",
                table: "Card",
                column: "ProductId",
                principalTable: "products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Card_User_UserId",
                table: "Card");

            migrationBuilder.DropForeignKey(
                name: "FK_Card_products_ProductId",
                table: "Card");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Card",
                table: "Card");

            migrationBuilder.DropIndex(
                name: "IX_Card_ProductId",
                table: "Card");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2bbaf133-ce2c-4b82-9faf-1bc8acce470c");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2e03212c-05d4-45c9-aa42-563d7a337a4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6817b84a-c9b0-44e6-9d25-4736c6673565");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "Card",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card",
                table: "Card",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "1e09ebad-06a6-43b3-9b70-62fab5544fa9", null, "Admin", "ADMIN" },
                    { "59155fdf-5402-49de-8a3c-62afb7360b17", null, "User", "USER" },
                    { "5f0b7ef5-c9bb-4116-80d5-4af56911f77f", null, "Shop", "SHOP" }
                });
        }
    }
}
