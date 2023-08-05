using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class UpdateNameShoper : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "AdminName",
                table: "shop",
                newName: "ShopName");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ShopName",
                table: "shop",
                newName: "AdminName");
        }
    }
}
