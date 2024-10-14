using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace D_Project.Migrations
{
    /// <inheritdoc />
    public partial class AddModelsProductSubCatsRelation : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "237231df-5fd1-413c-83a4-0c94ec61e2d4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d17796ad-7ab0-488c-8ec7-cf3a93d43aae");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fb57e9cd-fcf6-4260-8fc1-4486b32d556c");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "character varying(128)",
                maxLength: 128,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.CreateTable(
                name: "MainCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MainCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SubCategory",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Icon = table.Column<string>(type: "text", nullable: false),
                    MainCategoryId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SubCategory", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    Exparation = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    MainCategoryId = table.Column<Guid>(type: "uuid", nullable: false),
                    AppUserId = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Product_AspNetUsers_AppUserId",
                        column: x => x.AppUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Product_MainCategory_MainCategoryId",
                        column: x => x.MainCategoryId,
                        principalTable: "MainCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductSubCategory",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uuid", nullable: false),
                    SubCategoryId = table.Column<Guid>(type: "uuid", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductSubCategory", x => new { x.ProductId, x.SubCategoryId });
                    table.ForeignKey(
                        name: "FK_ProductSubCategory_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductSubCategory_SubCategory_SubCategoryId",
                        column: x => x.SubCategoryId,
                        principalTable: "SubCategory",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "21d9762a-8110-4b4b-bf50-c0e156edfe37", null, "Client", "CLIENT" },
                    { "633a6744-d770-4e0b-ada9-209c4c5785e1", null, "Admin", "ADMIN" },
                    { "7da8e03f-f9e5-47a6-aac8-e5e44a0d95bb", null, "Donator", "DONATOR" }
                });

            migrationBuilder.InsertData(
                table: "SubCategory",
                columns: new[] { "Id", "Description", "Icon", "MainCategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("07ff0b73-c7c0-4c00-b39d-b342ab005d4c"), "Media collection", "wwwroot/images/mainCategories/category.jpg", new Guid("05914267-4605-45f5-82b3-ba2bf084955e"), "CDs, DVDs, Blu-rays" },
                    { new Guid("14c57dc1-8c52-46b3-a9d1-62fc7b38a220"), "Gaming systems and games", "wwwroot/images/mainCategories/category.jpg", new Guid("b508421a-ac57-47fe-92a1-e9e839fde9f8"), "Video Games & Consoles" },
                    { new Guid("178c3b72-8bb9-4533-8eb8-f5199d26d7c3"), "Hats, scarves, belts, etc.", "wwwroot/images/mainCategories/category.jpg", new Guid("d06cb356-7dbc-4514-8b09-b2d4fbfb51fc"), "Accessories" },
                    { new Guid("1e72e900-8bdb-4b38-8bbb-4b0399916ebd"), "Apparel for women", "wwwroot/images/mainCategories/category.jpg", new Guid("d06cb356-7dbc-4514-8b09-b2d4fbfb51fc"), "Women's Clothing" },
                    { new Guid("28e54862-25b6-4500-946d-451f0bd6ee65"), "Smartphones and tablets", "wwwroot/images/mainCategories/category.jpg", new Guid("68ce9515-3997-4c7a-9963-cd4b19b1a9fd"), "Mobile Phones & Tablets" },
                    { new Guid("31f8ec51-bbaf-4c8a-90cc-2f6f93d19045"), "Utensils and appliances for the kitchen", "wwwroot/images/mainCategories/category.jpg", new Guid("be2579fe-816c-40b3-bd01-be5f9c9063ef"), "Kitchenware" },
                    { new Guid("3919d812-af91-40b6-be97-98ad61beaa8b"), "Decorative items for the home", "wwwroot/images/mainCategories/category.jpg", new Guid("be2579fe-816c-40b3-bd01-be5f9c9063ef"), "Home Décor" },
                    { new Guid("3f155ddb-dce1-4214-adde-17077f66af43"), "Bedding essentials", "wwwroot/images/mainCategories/category.jpg", new Guid("be2579fe-816c-40b3-bd01-be5f9c9063ef"), "Bedding & Linens" },
                    { new Guid("4cab9944-7813-4d43-b397-9b54305cf2bc"), "Household furniture", "wwwroot/images/mainCategories/category.jpg", new Guid("be2579fe-816c-40b3-bd01-be5f9c9063ef"), "Furniture" },
                    { new Guid("50e30ee0-d66b-4759-8b86-60ac7e14a46a"), "Televisions and audio equipment", "wwwroot/images/mainCategories/category.jpg", new Guid("68ce9515-3997-4c7a-9963-cd4b19b1a9fd"), "TVs & Audio Systems" },
                    { new Guid("5c443965-6991-458f-af1e-13ca6a10ad2a"), "Gear for various sports", "wwwroot/images/mainCategories/category.jpg", new Guid("c15893da-2b58-479f-8ae9-d93b7f156d5b"), "Sports Gear" },
                    { new Guid("5e806561-87e5-4fd0-ac25-25e2aeb3062e"), "Computers and laptops", "wwwroot/images/mainCategories/category.jpg", new Guid("68ce9515-3997-4c7a-9963-cd4b19b1a9fd"), "Computers & Laptops" },
                    { new Guid("5f3e00f5-932c-4785-b163-1aebd1b04a44"), "Equipment for gym workouts", "wwwroot/images/mainCategories/category.jpg", new Guid("c15893da-2b58-479f-8ae9-d93b7f156d5b"), "Gym Equipment" },
                    { new Guid("638125bf-9101-409f-9430-b1e89e2172d8"), "Apparel for men", "wwwroot/images/mainCategories/category.jpg", new Guid("d06cb356-7dbc-4514-8b09-b2d4fbfb51fc"), "Men's Clothing" },
                    { new Guid("7c2c8373-4884-4f06-9e3c-4530cc7cd990"), "Non-perishable food products", "wwwroot/images/mainCategories/category.jpg", new Guid("1dcd7648-fbae-4302-8ef7-c84dae621879"), "Non-Perishable Items" },
                    { new Guid("8142fb3b-785d-4fa8-a547-8f948459393d"), "Fiction, non-fiction, educational", "wwwroot/images/mainCategories/category.jpg", new Guid("05914267-4605-45f5-82b3-ba2bf084955e"), "Books" },
                    { new Guid("89f9518b-0ff8-498e-ab56-089d7dfb3b68"), "Equipment for outdoor activities", "wwwroot/images/mainCategories/category.jpg", new Guid("c15893da-2b58-479f-8ae9-d93b7f156d5b"), "Camping & Outdoor Gear" },
                    { new Guid("8f2a575c-04ee-4529-9123-ffeb61051de6"), "Bicycles and scooters for all ages", "wwwroot/images/mainCategories/category.jpg", new Guid("c15893da-2b58-479f-8ae9-d93b7f156d5b"), "Bicycles & Scooters" },
                    { new Guid("9012e5b7-9e80-4c3e-9954-e04c137de387"), "Appliances for home use", "wwwroot/images/mainCategories/category.jpg", new Guid("68ce9515-3997-4c7a-9963-cd4b19b1a9fd"), "Home Appliances" },
                    { new Guid("b9502c53-a152-4b36-9541-e7f498f5feec"), "Cleaning essentials", "wwwroot/images/mainCategories/category.jpg", new Guid("be2579fe-816c-40b3-bd01-be5f9c9063ef"), "Cleaning Supplies" },
                    { new Guid("ccd09a85-97f5-45da-a606-03e693411da0"), "Toys that promote learning", "wwwroot/images/mainCategories/category.jpg", new Guid("b508421a-ac57-47fe-92a1-e9e839fde9f8"), "Educational Toys" },
                    { new Guid("db17c983-3326-4b48-b5ff-0d80bef47d36"), "Canned food items", "wwwroot/images/mainCategories/category.jpg", new Guid("1dcd7648-fbae-4302-8ef7-c84dae621879"), "Canned Goods" },
                    { new Guid("dbccfe0c-101e-46e3-b30b-9e02c5024946"), "Footwear for all", "wwwroot/images/mainCategories/category.jpg", new Guid("d06cb356-7dbc-4514-8b09-b2d4fbfb51fc"), "Shoes & Footwear" },
                    { new Guid("df023da7-e15d-4444-a14c-34e0c4255931"), "Various magazines", "wwwroot/images/mainCategories/category.jpg", new Guid("05914267-4605-45f5-82b3-ba2bf084955e"), "Magazines" },
                    { new Guid("e167da48-5302-457d-b333-b0971d2ce9ed"), "Apparel for children", "wwwroot/images/mainCategories/category.jpg", new Guid("d06cb356-7dbc-4514-8b09-b2d4fbfb51fc"), "Children's Clothing" },
                    { new Guid("e48f8aec-e1b1-40d1-94a5-0eaf3f615647"), "Games for fun and challenges", "wwwroot/images/mainCategories/category.jpg", new Guid("b508421a-ac57-47fe-92a1-e9e839fde9f8"), "Board Games & Puzzles" },
                    { new Guid("f7b96a76-c589-499a-9ef7-9ffc2b53b73d"), "Food and formula for infants", "wwwroot/images/mainCategories/category.jpg", new Guid("1dcd7648-fbae-4302-8ef7-c84dae621879"), "Baby Food & Formula" },
                    { new Guid("fdf27400-6d7a-4bff-b933-5341003e37c4"), "Toys for young children", "wwwroot/images/mainCategories/category.jpg", new Guid("b508421a-ac57-47fe-92a1-e9e839fde9f8"), "Baby & Toddler Toys" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Product_AppUserId",
                table: "Product",
                column: "AppUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_MainCategoryId",
                table: "Product",
                column: "MainCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductSubCategory_SubCategoryId",
                table: "ProductSubCategory",
                column: "SubCategoryId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductSubCategory");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "SubCategory");

            migrationBuilder.DropTable(
                name: "MainCategory");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21d9762a-8110-4b4b-bf50-c0e156edfe37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "633a6744-d770-4e0b-ada9-209c4c5785e1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7da8e03f-f9e5-47a6-aac8-e5e44a0d95bb");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "AspNetUserTokens",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserTokens",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "ProviderKey",
                table: "AspNetUserLogins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.AlterColumn<string>(
                name: "LoginProvider",
                table: "AspNetUserLogins",
                type: "text",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "character varying(128)",
                oldMaxLength: 128);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "237231df-5fd1-413c-83a4-0c94ec61e2d4", null, "Admin", "ADMIN" },
                    { "d17796ad-7ab0-488c-8ec7-cf3a93d43aae", null, "Client", "CLIENT" },
                    { "fb57e9cd-fcf6-4260-8fc1-4486b32d556c", null, "Donator", "DONATOR" }
                });
        }
    }
}
