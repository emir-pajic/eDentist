using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.WebAPI.Migrations
{
    public partial class referentialActiononDeletetrtmtn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 15, 45, 34, 695, DateTimeKind.Local).AddTicks(8258), "A7Bu9G+D9bNpdvG6A39BjCWC7qs=", "meTvpKf8EQVWplgdWJlYgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 15, 45, 34, 695, DateTimeKind.Local).AddTicks(9028), "PcaQaEKULN0vs0KDbz/p/xChPTc=", "meTvpKf8EQVWplgdWJlYgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 15, 45, 34, 696, DateTimeKind.Local).AddTicks(1558), "PcaQaEKULN0vs0KDbz/p/xChPTc=", "meTvpKf8EQVWplgdWJlYgQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 15, 45, 34, 695, DateTimeKind.Local).AddTicks(8790), "PcaQaEKULN0vs0KDbz/p/xChPTc=", "meTvpKf8EQVWplgdWJlYgQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 15, 28, 17, 973, DateTimeKind.Local).AddTicks(6716), "zwjZ/MUAdWz6BhpBDfh2P1vHRRQ=", "tM9MY31Tdufvfws7xlljvQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 15, 28, 17, 973, DateTimeKind.Local).AddTicks(7544), "kRE1/ImOPR9XRbQOYmqGw6DzeQg=", "tM9MY31Tdufvfws7xlljvQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 15, 28, 17, 974, DateTimeKind.Local).AddTicks(192), "kRE1/ImOPR9XRbQOYmqGw6DzeQg=", "tM9MY31Tdufvfws7xlljvQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 15, 28, 17, 973, DateTimeKind.Local).AddTicks(7260), "kRE1/ImOPR9XRbQOYmqGw6DzeQg=", "tM9MY31Tdufvfws7xlljvQ==" });
        }
    }
}
