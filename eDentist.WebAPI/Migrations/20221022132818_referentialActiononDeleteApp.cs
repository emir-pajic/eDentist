using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.WebAPI.Migrations
{
    public partial class referentialActiononDeleteApp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 21, 55, 787, DateTimeKind.Local).AddTicks(1205), "vJX3RYD57tMYi8eIo+/JQ7pYB6E=", "3qnoAfkmPVm8RXM9vxafcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 21, 55, 787, DateTimeKind.Local).AddTicks(1873), "UFi6ri9b9sQolTfarQFrgNgklYk=", "3qnoAfkmPVm8RXM9vxafcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 21, 55, 787, DateTimeKind.Local).AddTicks(2071), "UFi6ri9b9sQolTfarQFrgNgklYk=", "3qnoAfkmPVm8RXM9vxafcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 21, 55, 787, DateTimeKind.Local).AddTicks(1641), "UFi6ri9b9sQolTfarQFrgNgklYk=", "3qnoAfkmPVm8RXM9vxafcQ==" });
        }
    }
}
