using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentist.WebAPI.Migrations
{
    public partial class seeded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Manufacturers",
                columns: new[] { "ManufacturerId", "CountryId", "FoundationYear", "Name" },
                values: new object[] { 1, 1, 1951, "Bosnalijek" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 14, 18, 16, 40, 238, DateTimeKind.Local).AddTicks(4252), "lRAzJxMS7B3ixl/qlRIYr9iLIOs=", "JcQKcwGtEM70qRnfYSXNOA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 14, 18, 16, 40, 245, DateTimeKind.Local).AddTicks(6521), "lVIpXBZkSy+IQMJk9Jznpr5ZFHA=", "m+hsAiyI7eGGZs8raIiNLw==" });

            migrationBuilder.InsertData(
                table: "Materials",
                columns: new[] { "MaterialId", "ManufacturerId", "Name" },
                values: new object[] { 1, 1, "Brufen 400mg" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Materials",
                keyColumn: "MaterialId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Manufacturers",
                keyColumn: "ManufacturerId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 14, 18, 12, 1, 619, DateTimeKind.Local).AddTicks(906), "qVs96KNnY9L5CJmxFM/vgCww/oo=", "NEE5zt2HTsRcYUMrxtRB7A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 14, 18, 12, 1, 626, DateTimeKind.Local).AddTicks(5402), "/PFmYkGg77MCGh3n/C2DwKVOlnU=", "l3ig3OoqpZm1F9/cP0/rog==" });
        }
    }
}
