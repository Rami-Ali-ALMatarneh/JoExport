using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class RShipUsersaCCOUNT_IdentityUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "User",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "User",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Shop",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "IdentityUserId",
                table: "Admin",
                type: "nvarchar(450)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "User");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "IdentityUserId",
                table: "Admin");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Admin");
        }
    }
}
