using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class UpdateTypeOfRoles : Migration
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
                keyValue: "a539899f-f936-4614-a367-b2873f4cad14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af6dd5e8-5afb-457f-b72a-8f43632fb2ec");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f8489caa-1302-4172-956a-28329585c575");

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfRoles",
                table: "User",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfRoles",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

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
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

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

            migrationBuilder.AlterColumn<string>(
                name: "TypeOfRoles",
                table: "Admin",
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
                    { "a539899f-f936-4614-a367-b2873f4cad14", null, "User", "USER" },
                    { "af6dd5e8-5afb-457f-b72a-8f43632fb2ec", null, "Admin", "ADMIN" },
                    { "f8489caa-1302-4172-956a-28329585c575", null, "Shop", "SHOP" }
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
