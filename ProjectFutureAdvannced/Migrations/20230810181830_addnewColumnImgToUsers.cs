using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class addnewColumnImgToUsers : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "231d5399-7e47-492b-832b-a6aa457d3f61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3844b5cb-016a-4f16-bef3-b6d889c205cf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "529ebbf2-b720-40a6-81c2-5a2c2be46504");

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "User",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Shop",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ImgUrl",
                table: "Admin",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7c6e856c-a728-4379-8725-d257c7e6ad39", null, "Admin", "ADMIN" },
                    { "a424a953-6a41-4743-b73f-078083fc413d", null, "Shop", "SHOP" },
                    { "f6590a23-f7a5-49b4-a882-b57e390daf12", null, "User", "USER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7c6e856c-a728-4379-8725-d257c7e6ad39");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a424a953-6a41-4743-b73f-078083fc413d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6590a23-f7a5-49b4-a882-b57e390daf12");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "User");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Shop");

            migrationBuilder.DropColumn(
                name: "ImgUrl",
                table: "Admin");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "231d5399-7e47-492b-832b-a6aa457d3f61", null, "User", "USER" },
                    { "3844b5cb-016a-4f16-bef3-b6d889c205cf", null, "Admin", "ADMIN" },
                    { "529ebbf2-b720-40a6-81c2-5a2c2be46504", null, "Shop", "SHOP" }
                });
        }
    }
}
