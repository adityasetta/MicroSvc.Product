using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MicroSvc.Product.Infrastructure.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Company", "Name", "Stock" },
                values: new object[] { new Guid("ee217de5-2294-403c-b123-9bbbfaf4e1c4"), "The Caco-cala ltd", "Caco-cala", 9000 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Company", "Name", "Stock" },
                values: new object[] { new Guid("0935b6a7-28bf-4d1b-9244-e7db08d165b9"), "Indiemie ltd", "Indie-mie", 1500 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Company", "Name", "Stock" },
                values: new object[] { new Guid("9ebe44e1-b6ae-4db0-8a08-aa7f3046888d"), "PT Torubaka", "Galus Mix", 756 });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "Id", "Company", "Name", "Stock" },
                values: new object[] { new Guid("290facd3-7a48-4d8b-820d-00015ea9c9aa"), "PT Sehat walafiat", "Katas-Katas", 75 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("0935b6a7-28bf-4d1b-9244-e7db08d165b9"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("290facd3-7a48-4d8b-820d-00015ea9c9aa"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("9ebe44e1-b6ae-4db0-8a08-aa7f3046888d"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "Id",
                keyValue: new Guid("ee217de5-2294-403c-b123-9bbbfaf4e1c4"));
        }
    }
}
