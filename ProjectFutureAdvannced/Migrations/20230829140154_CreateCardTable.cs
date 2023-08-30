using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class CreateCardTable : Migration
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
                keyValue: "3c00b655-70d5-42a3-ae18-8433fec4f6f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e3a570b-e7d5-41e5-a0c7-b2cc1e9ae623");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1e7f607-c08b-4612-b9b7-657ddb717032");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "Card");

            migrationBuilder.AlterColumn<int>(
                name: "UserId",
                table: "Card",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Card",
                table: "Card",
                columns: new[] { "UserId", "ProductId" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69ef6751-bf9b-473b-ad84-7185844d401d", null, "Admin", "ADMIN" },
                    { "6beb218c-9623-4f3c-b98d-ac6b47960b8d", null, "Shop", "SHOP" },
                    { "fc1728d4-634d-4782-bae7-74cd65bc318a", null, "User", "USER" }
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
                keyValue: "69ef6751-bf9b-473b-ad84-7185844d401d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6beb218c-9623-4f3c-b98d-ac6b47960b8d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fc1728d4-634d-4782-bae7-74cd65bc318a");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Card",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                    { "3c00b655-70d5-42a3-ae18-8433fec4f6f4", null, "User", "USER" },
                    { "5e3a570b-e7d5-41e5-a0c7-b2cc1e9ae623", null, "Admin", "ADMIN" },
                    { "d1e7f607-c08b-4612-b9b7-657ddb717032", null, "Shop", "SHOP" }
                });
        }
    }
}
