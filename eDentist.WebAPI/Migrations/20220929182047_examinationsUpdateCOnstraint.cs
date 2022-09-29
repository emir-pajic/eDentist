using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.WebAPI.Migrations
{
    public partial class examinationsUpdateCOnstraint : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 9, 29, 20, 20, 47, 557, DateTimeKind.Local).AddTicks(7265), "i2CpwZ0J8gCZIFAKzexf//SE1AM=", "gUTXb54oODio65Q/72Y2Dw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 9, 29, 20, 20, 47, 557, DateTimeKind.Local).AddTicks(8411), "iPWCbdUZhBRFixibjfaqjv6sMVM=", "F7k/fUjmU/uqpaK0f3ojcQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 8, 17, 9, 19, 8, 244, DateTimeKind.Local).AddTicks(5000), "pE5PXfj1iiIs+bS3ZGiZ5w6wHbk=", "vpV+t+TlW0LcSTOzSxt/Yg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 8, 17, 9, 19, 8, 249, DateTimeKind.Local).AddTicks(8351), "cQ/sOONBOW2RV1vibRvQefgnAyQ=", "dmqTpWryE3S7J+zChn4TVg==" });
        }
    }
}
