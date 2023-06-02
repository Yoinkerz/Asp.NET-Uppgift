using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Webapp.Migrations
{
    /// <inheritdoc />
    public partial class Tagsonallproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                column: "ConcurrencyStamp",
                value: "85fd5a0b-eec1-4426-b10c-5b8f9b2becc9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                column: "ConcurrencyStamp",
                value: "bf900362-4e20-486c-84f1-cad6a1bb04cd");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9d75486-1ed8-44e8-ab2b-4f5aea5bba4b", "AQAAAAIAAYagAAAAEHIVm9wODnOZYN4JfnhJjnFrnOiF79Oy+8x1hP6m8+7WGFlVeRZlakuuiEjlEQIhoA==", "b86e26bf-e98c-4394-aead-607ecc109fd9" });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "ProductId", "TagId" },
                values: new object[,]
                {
                    { 2, 2 },
                    { 3, 3 },
                    { 4, 1 },
                    { 5, 2 },
                    { 6, 3 },
                    { 7, 2 },
                    { 8, 1 },
                    { 9, 3 },
                    { 10, 1 },
                    { 11, 2 },
                    { 12, 2 },
                    { 13, 1 },
                    { 14, 3 },
                    { 15, 3 },
                    { 16, 2 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 6, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 7, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 8, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 9, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 10, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 11, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 12, 2 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 13, 1 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 14, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 15, 3 });

            migrationBuilder.DeleteData(
                table: "ProductTags",
                keyColumns: new[] { "ProductId", "TagId" },
                keyValues: new object[] { 16, 2 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                column: "ConcurrencyStamp",
                value: "12fafe2e-980a-48fc-a95a-cc49a90acba9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                column: "ConcurrencyStamp",
                value: "8e484bba-c13f-48f7-91e8-a9c0b95c815c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9204c8fa-e37f-4f5e-a766-adeb5963865a", "AQAAAAIAAYagAAAAEAUGCOiT4Q1hbp81USCfAJKVMWsegGL/6qfF8b7Jh7xAp+urbMWPcAC4YnDF65cWqA==", "65ac490e-54e4-43e5-8b24-e2f0f3a43d9b" });
        }
    }
}
