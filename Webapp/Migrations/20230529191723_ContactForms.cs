using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapp.Migrations
{
    /// <inheritdoc />
    public partial class ContactForms : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ContactForms",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContactForms", x => x.Id);
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                column: "ConcurrencyStamp",
                value: "c0358faf-8cfc-4425-b3ec-5a3afecd2f82");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                column: "ConcurrencyStamp",
                value: "a4734a34-73bb-417c-a0db-0a8fe72e28f0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9f0d517e-a265-4da9-b90d-72f01ca43c24", "AQAAAAIAAYagAAAAENkHrQUwB+a3M7BLi7SiRUBi+a5F0aLMesiEe3xmAd1gFomEzjBqyApTLHrXeJ37gw==", "036270b9-55a4-4b1b-a04e-94e5df81d3bb" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ContactForms");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                column: "ConcurrencyStamp",
                value: "d04c7b36-7911-46aa-a372-b75d22330bee");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                column: "ConcurrencyStamp",
                value: "14808a4d-4060-4117-bed9-25d6a23d51e9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "de896d92-1d10-43d7-bd57-40de2452aee3", "AQAAAAIAAYagAAAAENM99Y36E54+ho1ZnkBZ14bXVcJJ8wHQGkGD8VNa2eSlLEX86xP5XJAbqbnT6Rv3kQ==", "6ff7c0c2-e28c-4614-92c1-377e5b048fcd" });
        }
    }
}
