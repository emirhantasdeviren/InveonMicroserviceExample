using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Inveon.Services.ProductsAPI.Migrations
{
    /// <inheritdoc />
    public partial class SeedProductTables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CategoryName", "CreatedAt", "DeletedAt", "Description", "ImagePath", "Name", "Price", "UpdatedAt" },
                values: new object[,]
                {
                    { new Guid("27e1d3ca-fb77-41bc-a6fc-2a8f613fdbd7"), "Dessert", new DateTime(2023, 11, 1, 19, 27, 24, 770, DateTimeKind.Utc).AddTicks(7949), null, "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.", "sweetpie.jpg", "Sweet Pie", 10.99, new DateTime(2023, 11, 1, 19, 27, 24, 770, DateTimeKind.Utc).AddTicks(7949) },
                    { new Guid("3f2e27fc-e22f-4e93-96ad-b3fce779d4bd"), "Appetizer", new DateTime(2023, 11, 1, 19, 27, 24, 770, DateTimeKind.Utc).AddTicks(7874), null, "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.", "samosa.jpg", "Samosa", 15.0, new DateTime(2023, 11, 1, 19, 27, 24, 770, DateTimeKind.Utc).AddTicks(7875) },
                    { new Guid("a44fe600-0fa0-4fab-9aaa-3b81838b3eb8"), "Entree", new DateTime(2023, 11, 1, 19, 27, 24, 770, DateTimeKind.Utc).AddTicks(7960), null, "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.", "pavbhaji.jpg", "Pav Bhaji", 15.0, new DateTime(2023, 11, 1, 19, 27, 24, 770, DateTimeKind.Utc).AddTicks(7961) },
                    { new Guid("f3d2eade-a3f4-4b51-9d85-d4a4fa3002b6"), "Appetizer", new DateTime(2023, 11, 1, 19, 27, 24, 770, DateTimeKind.Utc).AddTicks(7904), null, "Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.", "panertikka.jpg", "Paneer Tikka", 13.99, new DateTime(2023, 11, 1, 19, 27, 24, 770, DateTimeKind.Utc).AddTicks(7904) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("27e1d3ca-fb77-41bc-a6fc-2a8f613fdbd7"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("3f2e27fc-e22f-4e93-96ad-b3fce779d4bd"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("a44fe600-0fa0-4fab-9aaa-3b81838b3eb8"));

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: new Guid("f3d2eade-a3f4-4b51-9d85-d4a4fa3002b6"));
        }
    }
}
