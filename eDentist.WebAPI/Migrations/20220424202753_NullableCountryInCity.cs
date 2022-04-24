using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentist.WebAPI.Migrations
{
    public partial class NullableCountryInCity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 4, 24, 22, 27, 52, 423, DateTimeKind.Local).AddTicks(9894), "xSNDhlKI4m7Yfw0GVt0bylqLy/E=", "QnZsvyHrXxgc0FHaH+ckKQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 4, 24, 22, 27, 52, 431, DateTimeKind.Local).AddTicks(4721), "8YpfJMTCCjc0ggKRnUR6qCx/Yxg=", "McFM7v6ww8eUBy2VNxNLvA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities");

            migrationBuilder.AlterColumn<int>(
                name: "CountryId",
                table: "Cities",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 4, 17, 12, 9, 51, 654, DateTimeKind.Local).AddTicks(6586), "f2NUEuEkVcSkDjEc16kTdMH703o=", "VOEjaEIOhb9LEzVEOd0ulw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 4, 17, 12, 9, 51, 668, DateTimeKind.Local).AddTicks(3141), "N5imdpoAkE8/Ef/1L9knN+6gwfw=", "gMNU5ocGThgIjzcN3VEFkw==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Cities_Countries_CountryId",
                table: "Cities",
                column: "CountryId",
                principalTable: "Countries",
                principalColumn: "CountryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
