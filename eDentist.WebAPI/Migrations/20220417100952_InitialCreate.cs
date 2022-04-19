using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentist.WebAPI.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 14, 20, 2, 9, 837, DateTimeKind.Local).AddTicks(1817), "rdeMpQ3Ma32hlWjVmRocuo4ZZsk=", "ehYTJaHprjq8z7S6ubdT/Q==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 14, 20, 2, 9, 844, DateTimeKind.Local).AddTicks(7927), "j0pkvcUfKGmp+P4PZ39ZKE7MBLc=", "5e90pUmXpPQTI0qeyWDzMQ==" });
        }
    }
}
