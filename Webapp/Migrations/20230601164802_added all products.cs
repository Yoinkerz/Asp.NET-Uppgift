using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Webapp.Migrations
{
    /// <inheritdoc />
    public partial class addedallproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                column: "ConcurrencyStamp",
                value: "aed6ac43-495a-43a4-9192-1c4941d301c0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                column: "ConcurrencyStamp",
                value: "625513a8-6ba4-4917-8660-80b0b13e741e");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f94ff19b-be58-41fb-99b1-318dca3070bc", "AQAAAAIAAYagAAAAEPdpl8eo2q2SqT1rI2utH9hGSZ9VKK9obtC79jIjauHVbabxqokfAwgjY3KK70a2vA==", "207a212d-82e8-4576-83bb-d10b74eafb5e" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 9, "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 66m, "Apple watch series" },
                    { 10, "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 39m, "Apple watch series" },
                    { 11, "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 110m, "Apple watch series" },
                    { 12, "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 200m, "Apple watch series" },
                    { 13, "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 999m, "Apple watch series" },
                    { 14, "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 550m, "Apple watch series" },
                    { 15, "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 315m, "Apple watch series" },
                    { 16, "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 59m, "Apple watch series" },
                    { 17, "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 100m, "Apple watch series" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                column: "ConcurrencyStamp",
                value: "52ec195b-7125-40f8-bb4d-10338d8797ce");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                column: "ConcurrencyStamp",
                value: "b2ce5e07-4396-4b7c-8bfa-f6472a84ac55");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d3db25f-f437-4d3f-82d7-da8c72522749", "AQAAAAIAAYagAAAAEK8JkO+PbAyZN9eQsstCZL7uvNZrdjL7GKCbEz8GO9qh4vL578RN/F2WbqbZQtqSfg==", "4638147e-8276-4b3a-8e35-d17258a10145" });
        }
    }
}
