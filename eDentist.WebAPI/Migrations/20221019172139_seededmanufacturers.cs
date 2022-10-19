using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.WebAPI.Migrations
{
    public partial class seededmanufacturers : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 1,
                column: "Name",
                value: "Bosnalijek d.d");

            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "CountryId", "FoundationYear", "Name" },
                values: new object[,]
                {
                    { 2, 1, 1962, "Hemofarm d.o.o" },
                    { 3, 2, 1973, "PLIVA d.o.o" },
                    { 4, 2, 1943, "Pharma S d.o.o" },
                    { 5, 3, 1983, "Farmahem d.o.o" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 19, 21, 39, 45, DateTimeKind.Local).AddTicks(1894), "uIbbqESOYUazQj9fcJcqSJEBa00=", "SB3ic5SmaSWmpjDTR59zAA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 1,
                column: "Name",
                value: "Bosnalijek");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 19, 6, 36, 64, DateTimeKind.Local).AddTicks(9974), "36c/9PkElStcHwbaDGYH+g/Lwls=", "vGqZ7kpjxBrklQawz5EmQA==" });
        }
    }
}
