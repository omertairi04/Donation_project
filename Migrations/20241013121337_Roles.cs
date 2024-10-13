using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace D_Project.Migrations
{
    /// <inheritdoc />
    public partial class Roles : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
