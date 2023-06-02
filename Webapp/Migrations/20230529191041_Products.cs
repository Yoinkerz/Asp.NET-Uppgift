using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Webapp.Migrations
{
    /// <inheritdoc />
    public partial class Products : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<decimal>(type: "money", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TagName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductTags",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    TagId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductTags", x => new { x.ProductId, x.TagId });
                    table.ForeignKey(
                        name: "FK_ProductTags_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductTags_Tags_TagId",
                        column: x => x.TagId,
                        principalTable: "Tags",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "Description", "ImageUrl", "Price", "Title" },
                values: new object[] { 1, "Block-67 is an affordable and improved CNC Bakeneko65 by ENG Studio. The improvements range from the sound-optimized internal dimensions to the multi-layout hot-swap PCB and the 17mm low front height. The included aluminum plate has cut-outs that make it screw-in stabilizer compatible. Block-67’s uniform 7mm bezels and sharp corners give it a nice blocky look.", "https://cdn.shopify.com/s/files/1/0295/3245/4956/products/Board_700x.png?v=1653736635", 1800m, "BLOCK-67 R2" });

            migrationBuilder.InsertData(
                table: "Tags",
                columns: new[] { "Id", "TagName" },
                values: new object[,]
                {
                    { 1, "new" },
                    { 2, "featured" },
                    { 3, "popular" }
                });

            migrationBuilder.InsertData(
                table: "ProductTags",
                columns: new[] { "ProductId", "TagId" },
                values: new object[] { 1, 1 });

            migrationBuilder.CreateIndex(
                name: "IX_ProductTags_TagId",
                table: "ProductTags",
                column: "TagId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductTags");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Tags");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "409ce090-0dcb-425e-ab5d-dd7a37c74959",
                column: "ConcurrencyStamp",
                value: "a676243f-9fa5-499d-82fe-369c1eed863a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "466a8cb7-a123-4dcf-b636-98c60a18ae80",
                column: "ConcurrencyStamp",
                value: "e9540c3f-c6f5-4387-8eb8-0c9d6190bfb8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6a45fa8b-9656-4336-99e3-5e41a07d0a88",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "496675f5-1554-4284-b0e4-d11d951ef991", "AQAAAAIAAYagAAAAEKsc/k06iNd6FZa4EHBPfIKseG1p7Say4aW5EDWM+JwX1T1Pr21LYXvDJ/iaUwCgxQ==", "8aa9b2d7-f60b-4986-a942-bcd46f1ce018" });
        }
    }
}
