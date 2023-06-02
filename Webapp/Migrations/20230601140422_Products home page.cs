using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Webapp.Migrations
{
    /// <inheritdoc />
    public partial class Productshomepage : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "Description",
                value: "The Flowerpot portable table lamp VP9 from &Tradition is an innovative version of Verner Panton's popular table lamp VP3. This portable table lamp is slightly smaller than the classic table lamp and is perfect indoors and outdoors to create an atmospheric atmosphere wherever you are. The lamp can be dimmed in three stages using the small steel knob on top of the lampshade.");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[,]
                {
                    { 3, "Co-engineered with Intel®, the Lenovo ThinkPad X1 Carbon Gen 11 meets Intel® Evo™ laptop design requirements, hardware specifications, and key user experience targets for consistent responsiveness, instant wake, all-day battery life, fast charging, and intelligent video conferencing. This Evo-certified device also includes Intel® Unison™ for seamless connectivity with your Android or iOS smart phone for calling, messaging, and file and photo sharing—all done from your laptop.\r\n\r\n", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 1000m, "laptop thinkpad lenovo" },
                    { 4, "The Buddy wall lamp is stripped down and feels industrial and at the same time Scandinavian. The black colour enhances the minimalist feeling of the lamp.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 20m, "Wall Lamp" },
                    { 5, "Comfortably zen, just like every run should be. With the Nike Flex Experience Run 11, we created a lightweight, clean design that feels as good as it looks. The shoes are supportive in all the right ways with movement so natural, you'll swear you've been wearing them for years.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 35m, "Gumshoes black fashion" },
                    { 6, "Give your wardrobe that extra something-something with the latest drop from Wednesday's Girl. Big on floral and ditsy prints, the brand helps bring your daytime thing together with its range of designs. Choose from cute co-ords for a look that’s twice as nice, or have some all-in-one fun with its jumpsuits and playsuits.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 28m, "Woman white dress" },
                    { 7, "The Hamilton Beach® Electric Kettle has 1500 watts to heat up to 1 liter of water faster than a microwave and safer than a stovetop. You'll love the convenience of making a quick, hot cup of tea, instant coffee, or hot cocoa without the long wait. This kettle is perfect for hectic mornings or anytime you're in a hurry and need boiling water fast.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 47m, "Kettle water boiler" },
                    { 8, "The possibilities for easy home cooking are nearly endless with the Aroma 6-Cup Rice Cooker. Enjoy a variety of food with this appliance, including soups and stews. Featuring a non-stick inner pot and a tempered glass lid, the Aroma Rice Cooker is incredibly versatile. ", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 60m, "Congee cooking rice cooker" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

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
                keyValue: 2,
                column: "Description",
                value: "Block-67 is an affordable and improved CNC Bakeneko65 by ENG Studio. The improvements range from the sound-optimized internal dimensions to the multi-layout hot-swap PCB and the 17mm low front height. The included aluminum plate has cut-outs that make it screw-in stabilizer compatible. Block-67’s uniform 7mm bezels and sharp corners give it a nice blocky look.");
        }
    }
}
