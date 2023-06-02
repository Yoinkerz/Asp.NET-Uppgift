using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapp.Migrations
{
    /// <inheritdoc />
    public partial class Fixingregistration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                column: "ConcurrencyStamp",
                value: "603493ba-3f30-4c89-8af3-de7e7d689f0a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                column: "ConcurrencyStamp",
                value: "f1502db6-18c7-4803-bc4b-6ae39fac5403");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2e98d168-67b7-448e-be54-97af522f1f1a", "AQAAAAIAAYagAAAAEDya0AM722zfRZP4yI8UKsikYDmisVSf6AjO68AEA/6bFK4xJA4zTLSI80VCfoqPPg==", "be3ff73b-339a-4581-8b5b-067e3f642b27" });
        }
    }
}
