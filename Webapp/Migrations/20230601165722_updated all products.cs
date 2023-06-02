using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Webapp.Migrations
{
    /// <inheritdoc />
    public partial class updatedallproducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17);

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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Add trendy table space to your living room with the CosmoLiving Westerleigh End Table", "CosmoLiving Westerleigh End Table" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Title" },
                values: new object[] { "A quiet, lightweight and portable mini fridge that can be used anywhere to cool or warm food, drinks, beer, snacks, breast milk, insulin, skincare and medications.", "Mini Portable Fridge" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Surround yourself with spatial sound technologies including Windows Sonic, Dolby Atmos, and DTS Headphone:X.", "Wireless Headset" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Title" },
                values: new object[] { "XBOX SERIES X: The fastest, most powerful Xbox ever. Explore rich new worlds with 12 teraflops of raw graphic processing power, DirectX ray tracing, a custom SSD, and 4K gaming.", "Xbox Series X" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Title" },
                values: new object[] { "1TB of storage increases the overall capacity of the Xbox Series X|S—collect thousands of games across four generations of Xbox without sacrificing performance", "Seagate Storage" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Rediscover everything you watch with billions of accurate colors and see impressive picture quality that is natural and beautiful, enhanced by XR Triluminos Pro.", "Sony 85 Inch 4K Ultra HD TV X90K Series" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Operated with frequency response of 50Hz-16KHz, the podcast microphone XLR delivers balanced audio range for smooth mid, bright high and stable bass, likely to resonate with your audience. Directional cardioid dynamic microphone corded will not exaggerate your voice, while rejects unwanted off-axis noise for vocal originality and intelligibility during your gaming streaming video recording. (Tips: Keep the top of end-addressing dynamic microphone AM8 facing audio source, and suggested recording range is 2 to 6 in.)", "FIFINE XLR/USB Dynamic Microphone" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Title" },
                values: new object[] { "These strings have a highly flexible, multi-strand nylon core and cater for artists who feel uncomfortable with steel strings. The resounding success of our Dominant string owes a lot to its similarity in tone and response to gut strings, without gut's attendant drawbacks. The sound of the Dominant string is full and mellow, yet rich in overtones. Its radiance, its ability to project sound without being metallic, comes to the fore both in arco and pizzicato. Comparable in sound to gut, without gut's disadvantages. Other advantages are Dominant's effortless response to intricate fingering and its tuning stability even under extreme atmospheric conditions. But Dominant's beauty of tone is not as long lasting as that of a steel string, a price the discerning musician will be prepared to pay for this quality of sound. Dominant strings should be changed at appropriate intervals to ensure continuity of tone color. N.B. The playing and tuning peg length of the string are critical, so the string used should be exactly matched to the instrument's measurements", "Dr Thomastik Cello Strings" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "Apple watch series" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "Apple watch series" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "Apple watch series" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "Apple watch series" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "Apple watch series" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "Apple watch series" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "Apple watch series" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Description", "Title" },
                values: new object[] { "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "Apple watch series" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 17, "Meet the most rugged and capable Apple Watch ever. With a robust titanium case, precision dual-frequency GPS, up to 36 hours of battery life,1 the freedom of cellular,2 and three specialized bands made for athletes and adventurers of all kinds.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 100m, "Apple watch series" });
        }
    }
}
