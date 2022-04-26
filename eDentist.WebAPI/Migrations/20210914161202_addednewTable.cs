using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentist.WebAPI.Migrations
{
    public partial class addednewTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ManufacturerId",
                table: "Materials",
                nullable: true,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    ManufacturerId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(nullable: true),
                    FoundationYear = table.Column<int>(nullable: false),
                    CountryId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.ManufacturerId);
                    table.ForeignKey(
                        name: "FK_Manufacturers_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Restrict);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_Materials_ManufacturerId",
                table: "Materials",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_CountryId",
                table: "Manufacturers",
                column: "CountryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Manufacturers_ManufacturerId",
                table: "Materials",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "ManufacturerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Manufacturers_ManufacturerId",
                table: "Materials");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropIndex(
                name: "IX_Materials_ManufacturerId",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "ManufacturerId",
                table: "Materials");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 14, 17, 34, 52, 526, DateTimeKind.Local).AddTicks(7501), "tBhhEWPVEjfs2AW+27vJXukIxdY=", "/mGY/nNKSS9TuY7pGJbjUA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 14, 17, 34, 52, 540, DateTimeKind.Local).AddTicks(692), "HArO7THp6MX1GD6X20YPMC758YI=", "KfbHDtE4Ph9q3K3woiIgbA==" });
        }
    }
}
