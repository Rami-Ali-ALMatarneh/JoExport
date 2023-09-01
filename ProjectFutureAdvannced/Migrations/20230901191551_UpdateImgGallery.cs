using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class UpdateImgGallery : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Gallery_Shop_ShopId",
                table: "Gallery");

            migrationBuilder.DropForeignKey(
                name: "FK_Post_Shop_ShopId",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Post",
                table: "Post");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Gallery",
                table: "Gallery");

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

            migrationBuilder.RenameTable(
                name: "Post",
                newName: "posts");

            migrationBuilder.RenameTable(
                name: "Gallery",
                newName: "galleries");

            migrationBuilder.RenameIndex(
                name: "IX_Post_ShopId",
                table: "posts",
                newName: "IX_posts_ShopId");

            migrationBuilder.RenameIndex(
                name: "IX_Gallery_ShopId",
                table: "galleries",
                newName: "IX_galleries_ShopId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "posts",
                type: "datetime2",
                nullable: false,
                defaultValueSql: "GETDATE()",
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AddPrimaryKey(
                name: "PK_posts",
                table: "posts",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_galleries",
                table: "galleries",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "43e278c1-9952-4099-a3bb-d5af8890e44f", null, "Shop", "SHOP" },
                    { "e4a8715e-52cd-48e2-b089-40aa38fb874f", null, "Admin", "ADMIN" },
                    { "ed6e76e2-b4c7-4c04-9bfb-ac67024a67ef", null, "User", "USER" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_galleries_Shop_ShopId",
                table: "galleries",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_posts_Shop_ShopId",
                table: "posts",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_galleries_Shop_ShopId",
                table: "galleries");

            migrationBuilder.DropForeignKey(
                name: "FK_posts_Shop_ShopId",
                table: "posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_posts",
                table: "posts");

            migrationBuilder.DropPrimaryKey(
                name: "PK_galleries",
                table: "galleries");

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

            migrationBuilder.RenameTable(
                name: "posts",
                newName: "Post");

            migrationBuilder.RenameTable(
                name: "galleries",
                newName: "Gallery");

            migrationBuilder.RenameIndex(
                name: "IX_posts_ShopId",
                table: "Post",
                newName: "IX_Post_ShopId");

            migrationBuilder.RenameIndex(
                name: "IX_galleries_ShopId",
                table: "Gallery",
                newName: "IX_Gallery_ShopId");

            migrationBuilder.AlterColumn<DateTime>(
                name: "DateTime",
                table: "Post",
                type: "datetime2",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldDefaultValueSql: "GETDATE()");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Post",
                table: "Post",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gallery",
                table: "Gallery",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2bbaf133-ce2c-4b82-9faf-1bc8acce470c", null, "User", "USER" },
                    { "2e03212c-05d4-45c9-aa42-563d7a337a4e", null, "Admin", "ADMIN" },
                    { "6817b84a-c9b0-44e6-9d25-4736c6673565", null, "Shop", "SHOP" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Gallery_Shop_ShopId",
                table: "Gallery",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Post_Shop_ShopId",
                table: "Post",
                column: "ShopId",
                principalTable: "Shop",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
