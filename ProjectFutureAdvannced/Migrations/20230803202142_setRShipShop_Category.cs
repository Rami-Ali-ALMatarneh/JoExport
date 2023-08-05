using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class setRShipShop_Category : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CategorysType",
                table: "shop",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddUniqueConstraint(
                name: "AK_Categories_Name",
                table: "Categories",
                column: "Name");

            migrationBuilder.UpdateData(
                table: "shop",
                keyColumn: "Id",
                keyValue: 1,
                column: "CategorysType",
                value: 2);

            migrationBuilder.UpdateData(
                table: "shop",
                keyColumn: "Id",
                keyValue: 2,
                column: "CategorysType",
                value: 1);

            migrationBuilder.UpdateData(
                table: "shop",
                keyColumn: "Id",
                keyValue: 3,
                column: "CategorysType",
                value: 4);

            migrationBuilder.UpdateData(
                table: "shop",
                keyColumn: "Id",
                keyValue: 4,
                column: "CategorysType",
                value: 0);

            migrationBuilder.UpdateData(
                table: "shop",
                keyColumn: "Id",
                keyValue: 5,
                column: "CategorysType",
                value: 6);

            migrationBuilder.UpdateData(
                table: "shop",
                keyColumn: "Id",
                keyValue: 6,
                column: "CategorysType",
                value: 7);

            migrationBuilder.CreateIndex(
                name: "IX_shop_CategorysType",
                table: "shop",
                column: "CategorysType",
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_shop_Categories_CategorysType",
                table: "shop",
                column: "CategorysType",
                principalTable: "Categories",
                principalColumn: "Name",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_shop_Categories_CategorysType",
                table: "shop");

            migrationBuilder.DropIndex(
                name: "IX_shop_CategorysType",
                table: "shop");

            migrationBuilder.DropUniqueConstraint(
                name: "AK_Categories_Name",
                table: "Categories");

            migrationBuilder.DropColumn(
                name: "CategorysType",
                table: "shop");
        }
    }
}
