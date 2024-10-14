using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace D_Project.Migrations
{
    /// <inheritdoc />
    public partial class MainCategoryEnitites : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("07ff0b73-c7c0-4c00-b39d-b342ab005d4c"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("14c57dc1-8c52-46b3-a9d1-62fc7b38a220"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("178c3b72-8bb9-4533-8eb8-f5199d26d7c3"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("1e72e900-8bdb-4b38-8bbb-4b0399916ebd"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("28e54862-25b6-4500-946d-451f0bd6ee65"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("31f8ec51-bbaf-4c8a-90cc-2f6f93d19045"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("3919d812-af91-40b6-be97-98ad61beaa8b"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("3f155ddb-dce1-4214-adde-17077f66af43"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("4cab9944-7813-4d43-b397-9b54305cf2bc"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("50e30ee0-d66b-4759-8b86-60ac7e14a46a"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("5c443965-6991-458f-af1e-13ca6a10ad2a"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("5e806561-87e5-4fd0-ac25-25e2aeb3062e"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("5f3e00f5-932c-4785-b163-1aebd1b04a44"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("638125bf-9101-409f-9430-b1e89e2172d8"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("7c2c8373-4884-4f06-9e3c-4530cc7cd990"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("8142fb3b-785d-4fa8-a547-8f948459393d"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("89f9518b-0ff8-498e-ab56-089d7dfb3b68"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("8f2a575c-04ee-4529-9123-ffeb61051de6"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("9012e5b7-9e80-4c3e-9954-e04c137de387"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("b9502c53-a152-4b36-9541-e7f498f5feec"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("ccd09a85-97f5-45da-a606-03e693411da0"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("db17c983-3326-4b48-b5ff-0d80bef47d36"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("dbccfe0c-101e-46e3-b30b-9e02c5024946"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("df023da7-e15d-4444-a14c-34e0c4255931"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("e167da48-5302-457d-b333-b0971d2ce9ed"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("e48f8aec-e1b1-40d1-94a5-0eaf3f615647"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("f7b96a76-c589-499a-9ef7-9ffc2b53b73d"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("fdf27400-6d7a-4bff-b933-5341003e37c4"));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "5744c482-4977-4167-aee4-df2edfcd8b82", null, "Client", "CLIENT" },
                    { "61a513ae-58e7-44b9-83ed-bb74b4d5f103", null, "Admin", "ADMIN" },
                    { "70351cba-1cd5-49a5-9857-f1793a895a63", null, "Donator", "DONATOR" }
                });

            migrationBuilder.InsertData(
                table: "MainCategory",
                columns: new[] { "Id", "Description", "Icon", "Name" },
                values: new object[,]
                {
                    { new Guid("61468241-641e-4146-a7be-4b15b7ee338b"), "Every day house hold items", "wwwroot/images/mainCategories/category.jpg", "Household Items" },
                    { new Guid("760f7733-7179-4331-b547-d0d543c404d8"), "Apparel and accessories", "wwwroot/images/mainCategories/category.jpg", "Clothing" },
                    { new Guid("8638f166-0389-409a-88ef-c7d26389da75"), "Donate your Toys and Games.", "wwwroot/images/mainCategories/category.jpg", "Toys and Games" },
                    { new Guid("d413b22e-7fcd-4978-adc1-8c32406695a0"), "Donate your food and groceries.", "wwwroot/images/mainCategories/category.jpg", "Food and Groceries" },
                    { new Guid("dc48daff-cd3d-477d-a21e-52c830b61006"), "Donate your sport or fitness equipment.", "wwwroot/images/mainCategories/category.jpg", "Sports of Fitness Equipment" },
                    { new Guid("dd9b40e5-3af8-495a-8e89-974949f4f51f"), "Electronics", "wwwroot/images/mainCategories/category.jpg", "Electronics" },
                    { new Guid("f573225d-2181-4083-8a2a-8a4317b3fca9"), "Donate your books or medias.", "wwwroot/images/mainCategories/category.jpg", "Books and Media" }
                });

            migrationBuilder.InsertData(
                table: "SubCategory",
                columns: new[] { "Id", "Description", "Icon", "MainCategoryId", "Name" },
                values: new object[,]
                {
                    { new Guid("05344845-cb56-4d17-8f6a-81dbb3f64cf4"), "Equipment for gym workouts", "wwwroot/images/mainCategories/category.jpg", new Guid("dc48daff-cd3d-477d-a21e-52c830b61006"), "Gym Equipment" },
                    { new Guid("0ddc2c2d-ee9c-43f0-a6ae-87fbe049c6cf"), "Footwear for all", "wwwroot/images/mainCategories/category.jpg", new Guid("760f7733-7179-4331-b547-d0d543c404d8"), "Shoes & Footwear" },
                    { new Guid("131e6f0d-098a-417e-a86e-dd479b62c638"), "Non-perishable food products", "wwwroot/images/mainCategories/category.jpg", new Guid("d413b22e-7fcd-4978-adc1-8c32406695a0"), "Non-Perishable Items" },
                    { new Guid("1fdb90bf-a0f2-4468-b44b-6f6fa5299a31"), "Apparel for children", "wwwroot/images/mainCategories/category.jpg", new Guid("760f7733-7179-4331-b547-d0d543c404d8"), "Children's Clothing" },
                    { new Guid("4196a922-1e7d-432a-a4e2-cc20bfd31104"), "Hats, scarves, belts, etc.", "wwwroot/images/mainCategories/category.jpg", new Guid("760f7733-7179-4331-b547-d0d543c404d8"), "Accessories" },
                    { new Guid("42a3bde9-4f4e-4547-832f-2f34dd2c53e8"), "Gaming systems and games", "wwwroot/images/mainCategories/category.jpg", new Guid("8638f166-0389-409a-88ef-c7d26389da75"), "Video Games & Consoles" },
                    { new Guid("44c1366e-7c0c-45c4-917d-d124016f6a4e"), "Various magazines", "wwwroot/images/mainCategories/category.jpg", new Guid("f573225d-2181-4083-8a2a-8a4317b3fca9"), "Magazines" },
                    { new Guid("464c608f-d435-4c24-b1bf-2e2b0f066e77"), "Toys for young children", "wwwroot/images/mainCategories/category.jpg", new Guid("8638f166-0389-409a-88ef-c7d26389da75"), "Baby & Toddler Toys" },
                    { new Guid("48e2afba-1eee-4612-b70e-3e9ade302439"), "Fiction, non-fiction, educational", "wwwroot/images/mainCategories/category.jpg", new Guid("f573225d-2181-4083-8a2a-8a4317b3fca9"), "Books" },
                    { new Guid("5691d3de-7a07-4afb-a303-e18da5d2133b"), "Apparel for men", "wwwroot/images/mainCategories/category.jpg", new Guid("760f7733-7179-4331-b547-d0d543c404d8"), "Men's Clothing" },
                    { new Guid("5ad0a04f-9eaf-4ba6-8ee5-1bd9453a1961"), "Utensils and appliances for the kitchen", "wwwroot/images/mainCategories/category.jpg", new Guid("61468241-641e-4146-a7be-4b15b7ee338b"), "Kitchenware" },
                    { new Guid("67412f37-685a-4394-8e2d-3d802b743ecd"), "Computers and laptops", "wwwroot/images/mainCategories/category.jpg", new Guid("dd9b40e5-3af8-495a-8e89-974949f4f51f"), "Computers & Laptops" },
                    { new Guid("6995368a-c749-48ea-87c3-6c6f84b4a708"), "Cleaning essentials", "wwwroot/images/mainCategories/category.jpg", new Guid("61468241-641e-4146-a7be-4b15b7ee338b"), "Cleaning Supplies" },
                    { new Guid("7b5872f9-cceb-4584-bb84-3bd0ec4a1d74"), "Decorative items for the home", "wwwroot/images/mainCategories/category.jpg", new Guid("61468241-641e-4146-a7be-4b15b7ee338b"), "Home Décor" },
                    { new Guid("7c86f696-e777-45bc-be6a-a3e3ad30d82d"), "Gear for various sports", "wwwroot/images/mainCategories/category.jpg", new Guid("dc48daff-cd3d-477d-a21e-52c830b61006"), "Sports Gear" },
                    { new Guid("a991cf5d-712d-43dd-a2f6-49ec2db08b9d"), "Appliances for home use", "wwwroot/images/mainCategories/category.jpg", new Guid("dd9b40e5-3af8-495a-8e89-974949f4f51f"), "Home Appliances" },
                    { new Guid("aba87aea-2bf6-4341-ac5f-5a572fa9cee8"), "Canned food items", "wwwroot/images/mainCategories/category.jpg", new Guid("d413b22e-7fcd-4978-adc1-8c32406695a0"), "Canned Goods" },
                    { new Guid("abd616ce-a2dd-49ed-b0f3-0691bc680491"), "Food and formula for infants", "wwwroot/images/mainCategories/category.jpg", new Guid("d413b22e-7fcd-4978-adc1-8c32406695a0"), "Baby Food & Formula" },
                    { new Guid("ae2814e3-953c-4333-8089-3cb0ae9dc5dc"), "Equipment for outdoor activities", "wwwroot/images/mainCategories/category.jpg", new Guid("dc48daff-cd3d-477d-a21e-52c830b61006"), "Camping & Outdoor Gear" },
                    { new Guid("af52bd61-4722-49db-993f-6a92d61f56bb"), "Apparel for women", "wwwroot/images/mainCategories/category.jpg", new Guid("760f7733-7179-4331-b547-d0d543c404d8"), "Women's Clothing" },
                    { new Guid("afe15908-a50f-435b-a3e1-b48275c1c256"), "Smartphones and tablets", "wwwroot/images/mainCategories/category.jpg", new Guid("dd9b40e5-3af8-495a-8e89-974949f4f51f"), "Mobile Phones & Tablets" },
                    { new Guid("b1d2f97e-7b70-4223-b400-568cc138cee8"), "Household furniture", "wwwroot/images/mainCategories/category.jpg", new Guid("61468241-641e-4146-a7be-4b15b7ee338b"), "Furniture" },
                    { new Guid("bbe1c35d-3299-408e-b228-2b13bdbc6582"), "Bedding essentials", "wwwroot/images/mainCategories/category.jpg", new Guid("61468241-641e-4146-a7be-4b15b7ee338b"), "Bedding & Linens" },
                    { new Guid("df26de71-c0ed-4710-bbf9-115bdfddc99f"), "Bicycles and scooters for all ages", "wwwroot/images/mainCategories/category.jpg", new Guid("dc48daff-cd3d-477d-a21e-52c830b61006"), "Bicycles & Scooters" },
                    { new Guid("e7ee9b9c-bb31-4cfc-8b9e-b005754c681a"), "Games for fun and challenges", "wwwroot/images/mainCategories/category.jpg", new Guid("8638f166-0389-409a-88ef-c7d26389da75"), "Board Games & Puzzles" },
                    { new Guid("ee52126a-dc5c-41cb-9977-e2744ee3199f"), "Toys that promote learning", "wwwroot/images/mainCategories/category.jpg", new Guid("8638f166-0389-409a-88ef-c7d26389da75"), "Educational Toys" },
                    { new Guid("f7d9ae3f-8fa5-4b18-ba8d-a7718738c18f"), "Televisions and audio equipment", "wwwroot/images/mainCategories/category.jpg", new Guid("dd9b40e5-3af8-495a-8e89-974949f4f51f"), "TVs & Audio Systems" },
                    { new Guid("fdd80bdf-e15c-4658-a851-32770b8e3c88"), "Media collection", "wwwroot/images/mainCategories/category.jpg", new Guid("f573225d-2181-4083-8a2a-8a4317b3fca9"), "CDs, DVDs, Blu-rays" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5744c482-4977-4167-aee4-df2edfcd8b82");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61a513ae-58e7-44b9-83ed-bb74b4d5f103");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "70351cba-1cd5-49a5-9857-f1793a895a63");

            migrationBuilder.DeleteData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: new Guid("61468241-641e-4146-a7be-4b15b7ee338b"));

            migrationBuilder.DeleteData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: new Guid("760f7733-7179-4331-b547-d0d543c404d8"));

            migrationBuilder.DeleteData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: new Guid("8638f166-0389-409a-88ef-c7d26389da75"));

            migrationBuilder.DeleteData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: new Guid("d413b22e-7fcd-4978-adc1-8c32406695a0"));

            migrationBuilder.DeleteData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: new Guid("dc48daff-cd3d-477d-a21e-52c830b61006"));

            migrationBuilder.DeleteData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: new Guid("dd9b40e5-3af8-495a-8e89-974949f4f51f"));

            migrationBuilder.DeleteData(
                table: "MainCategory",
                keyColumn: "Id",
                keyValue: new Guid("f573225d-2181-4083-8a2a-8a4317b3fca9"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("05344845-cb56-4d17-8f6a-81dbb3f64cf4"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("0ddc2c2d-ee9c-43f0-a6ae-87fbe049c6cf"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("131e6f0d-098a-417e-a86e-dd479b62c638"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("1fdb90bf-a0f2-4468-b44b-6f6fa5299a31"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("4196a922-1e7d-432a-a4e2-cc20bfd31104"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("42a3bde9-4f4e-4547-832f-2f34dd2c53e8"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("44c1366e-7c0c-45c4-917d-d124016f6a4e"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("464c608f-d435-4c24-b1bf-2e2b0f066e77"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("48e2afba-1eee-4612-b70e-3e9ade302439"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("5691d3de-7a07-4afb-a303-e18da5d2133b"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("5ad0a04f-9eaf-4ba6-8ee5-1bd9453a1961"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("67412f37-685a-4394-8e2d-3d802b743ecd"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("6995368a-c749-48ea-87c3-6c6f84b4a708"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("7b5872f9-cceb-4584-bb84-3bd0ec4a1d74"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("7c86f696-e777-45bc-be6a-a3e3ad30d82d"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("a991cf5d-712d-43dd-a2f6-49ec2db08b9d"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("aba87aea-2bf6-4341-ac5f-5a572fa9cee8"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("abd616ce-a2dd-49ed-b0f3-0691bc680491"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("ae2814e3-953c-4333-8089-3cb0ae9dc5dc"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("af52bd61-4722-49db-993f-6a92d61f56bb"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("afe15908-a50f-435b-a3e1-b48275c1c256"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("b1d2f97e-7b70-4223-b400-568cc138cee8"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("bbe1c35d-3299-408e-b228-2b13bdbc6582"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("df26de71-c0ed-4710-bbf9-115bdfddc99f"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("e7ee9b9c-bb31-4cfc-8b9e-b005754c681a"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("ee52126a-dc5c-41cb-9977-e2744ee3199f"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("f7d9ae3f-8fa5-4b18-ba8d-a7718738c18f"));

            migrationBuilder.DeleteData(
                table: "SubCategory",
                keyColumn: "Id",
                keyValue: new Guid("fdd80bdf-e15c-4658-a851-32770b8e3c88"));

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
        }
    }
}
