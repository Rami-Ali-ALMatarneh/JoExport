using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class UpdateForeignKeyInUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_AspNetUsers_IdentityUserId",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_Shop_AspNetUsers_IdentityUserId",
                table: "Shop");

            migrationBuilder.DropForeignKey(
                name: "FK_User_AspNetUsers_IdentityUserId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_IdentityUserId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Shop_IdentityUserId",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Admin_IdentityUserId",
                table: "Admin");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "69c63641-9d23-43d6-99ca-d8004e3c5408");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8456a444-423e-4dca-81c1-c94a7c0c54c3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "879bf6ff-7899-4727-8b9f-8685361861e9");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Admin");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "User",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Shop",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Admin",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "594cd755-861c-4876-93e4-fdf223e25760", null, "Shop", "SHOP" },
                    { "a5fc1fa8-b94c-47ea-9c84-b369e273ad3a", null, "User", "USER" },
                    { "ac29bdc3-8902-467d-bee9-4fde85813987", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_UserId",
                table: "User",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_UserId",
                table: "Shop",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_UserId",
                table: "Admin",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_AspNetUsers_UserId",
                table: "Admin",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_AspNetUsers_UserId",
                table: "Shop",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_User_AspNetUsers_UserId",
                table: "User",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Admin_AspNetUsers_UserId",
                table: "Admin");

            migrationBuilder.DropForeignKey(
                name: "FK_Shop_AspNetUsers_UserId",
                table: "Shop");

            migrationBuilder.DropForeignKey(
                name: "FK_User_AspNetUsers_UserId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_User_UserId",
                table: "User");

            migrationBuilder.DropIndex(
                name: "IX_Shop_UserId",
                table: "Shop");

            migrationBuilder.DropIndex(
                name: "IX_Admin_UserId",
                table: "Admin");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "594cd755-861c-4876-93e4-fdf223e25760");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a5fc1fa8-b94c-47ea-9c84-b369e273ad3a");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ac29bdc3-8902-467d-bee9-4fde85813987");

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "User",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Shop",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "UserId",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Admin",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "69c63641-9d23-43d6-99ca-d8004e3c5408", null, "Shop", "SHOP" },
                    { "8456a444-423e-4dca-81c1-c94a7c0c54c3", null, "User", "USER" },
                    { "879bf6ff-7899-4727-8b9f-8685361861e9", null, "Admin", "ADMIN" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_User_IdentityUserId",
                table: "User",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Shop_IdentityUserId",
                table: "Shop",
                column: "IdentityUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Admin_IdentityUserId",
                table: "Admin",
                column: "IdentityUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Admin_AspNetUsers_IdentityUserId",
                table: "Admin",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Shop_AspNetUsers_IdentityUserId",
                table: "Shop",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_User_AspNetUsers_IdentityUserId",
                table: "User",
                column: "IdentityUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }
    }
}
