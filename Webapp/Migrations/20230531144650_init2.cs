using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapp.Migrations
{
    /// <inheritdoc />
    public partial class init2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                column: "ConcurrencyStamp",
                value: "d0a87a15-403a-4bb8-96b4-695d1771ffea");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                column: "ConcurrencyStamp",
                value: "433416d9-06f4-445b-bfef-33f204fad3d7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "271b1979-c79c-4c49-97c3-baa6cdf5a9b8", "AQAAAAIAAYagAAAAEMuxN5G+fXPQ/wftVXZQ1BlBkIRsWoJFUuh777oCd3Xpp3KyfgCFAN+10BIJlOf2Mw==", "154f5c0c-9cd5-4f6c-9ceb-eb441c7f2c7b" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
