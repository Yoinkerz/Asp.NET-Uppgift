using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapp.Migrations
{
    /// <inheritdoc />
    public partial class Productstest : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                column: "ConcurrencyStamp",
                value: "c8e2b634-9685-45bb-9d8b-18de864e7ea1");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                column: "ConcurrencyStamp",
                value: "4161a156-5ae5-43b4-9776-ab7a90441982");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87544190-6366-43b7-8e3d-15627d0c5807", "AQAAAAIAAYagAAAAEDxerfIvTBli7MxV/cN34sj+Zj5nIk36I60EqkLsNWBHmL0+xeT5jtFb5jsoJQiR8Q==", "25749463-c412-41f7-8588-775cee7c073a" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "Apple watch series" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 2, "Block-67 is an affordable and improved CNC Bakeneko65 by ENG Studio. The improvements range from the sound-optimized internal dimensions to the multi-layout hot-swap PCB and the 17mm low front height. The included aluminum plate has cut-outs that make it screw-in stabilizer compatible. Block-67’s uniform 7mm bezels and sharp corners give it a nice blocky look.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 90m, "Table Lamp" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Block-67 is an affordable and improved CNC Bakeneko65 by ENG Studio. The improvements range from the sound-optimized internal dimensions to the multi-layout hot-swap PCB and the 17mm low front height. The included aluminum plate has cut-outs that make it screw-in stabilizer compatible. Block-67’s uniform 7mm bezels and sharp corners give it a nice blocky look.", "BLOCK-67 R2" });
        }
    }
}
