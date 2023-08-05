using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ProjectFutureAdvannced.Migrations
{
    /// <inheritdoc />
    public partial class SetSeedShop : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "shop",
                columns: new[] { "Id", "ConfirmPassword", "EmailAddress", "Password", "ShopName", "TypeOfUser", "imgShop", "phone" },
                values: new object[,]
                {
                    { 1, "bmwcar12345@", "bmw1@gmail.com", "bmwcar12345@", "BMW", 2, "bmw.jpg", "776924478" },
                    { 2, "hpElectronic12345@", "hp1@gmail.com", "hpElectronic12345@", "Hp", 2, "hp.jpg", "776924478" },
                    { 3, "Adidas12345@", "Adidas@gmail.com", "Adidas12345@", "Adidas", 2, "Adidas.jpg", "7888888888" },
                    { 4, "IKEA123456@", "IKEA@gmail.com", "IKEA123456@", "IKEA", 2, "IKEA.jpg", "776924478" },
                    { 5, "LOREAL12345", "LOREAL@gmail.com", "LOREAL12345", "LOREAL", 2, "LOreal.jpg", "776924458" },
                    { 6, "BABY2BABY123", "BABY2BABY@gmail.com", "BABY2BABY123", "BABY2BABY", 2, "baby2baby.jpg", "776924478" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "shop",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "shop",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "shop",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "shop",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "shop",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "shop",
                keyColumn: "Id",
                keyValue: 6);
        }
    }
}
