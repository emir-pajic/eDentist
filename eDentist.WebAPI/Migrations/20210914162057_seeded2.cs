using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentist.WebAPI.Migrations
{
    public partial class seeded2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 14, 18, 20, 56, 721, DateTimeKind.Local).AddTicks(7421), "m5kAOfViP3BKVc3ut1LPqgWuY9E=", "13XMNiI/Z42jzJQPIFzoSA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 14, 18, 20, 56, 728, DateTimeKind.Local).AddTicks(8993), "ID/oJub9cXfjxCGlUTLmZ2OuhIA=", "/6+aCpfvUIEMgU4ZjK23QQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
