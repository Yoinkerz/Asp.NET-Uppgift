using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapp.Migrations
{
    /// <inheritdoc />
    public partial class backendlogin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                column: "ConcurrencyStamp",
                value: "87fb2c76-04e5-4521-b6af-37e74951eb51");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                column: "ConcurrencyStamp",
                value: "0661d0d3-a5de-4315-95f5-df29fdc468b2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f3eaa5f4-83e1-4c1e-9f5e-5bb9135bbe68", "AQAAAAIAAYagAAAAEL1Yq639g4U80Gt4tsy7hYJaql2jMvCEDdC4mqBO4C5SakfFe+XUoKD00trQgU8IMQ==", "287aea40-f3cb-4810-983e-2cb882777f69" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
    }
}
