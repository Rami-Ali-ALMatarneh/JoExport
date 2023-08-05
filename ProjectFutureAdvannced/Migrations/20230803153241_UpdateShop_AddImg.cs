using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class UpdateShop_AddImg : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "imgShop",
                table: "shop",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "imgShop",
                table: "shop");
        }
    }
}
