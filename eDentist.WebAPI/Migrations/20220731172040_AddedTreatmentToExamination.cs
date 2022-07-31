using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentist.WebAPI.Migrations
{
    public partial class AddedTreatmentToExamination : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 7, 31, 19, 20, 40, 83, DateTimeKind.Local).AddTicks(8909), "ckT1s/ADwAWgv7LVbpkg7QM/APE=", "xA7fOgb5JaK/GdCHBG5dkw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 7, 31, 19, 20, 40, 90, DateTimeKind.Local).AddTicks(9377), "aSsFmuh/FVbDoE4X4ykgsPdLopg=", "wcL7eoZ5iqzEHHkOUJskNA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 57, 37, 895, DateTimeKind.Local).AddTicks(4129), "TmvCnaofEABa0dqoS3NY439TVdU=", "hDCE04vfLU7SCi904Jm12g==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 7, 26, 23, 57, 37, 899, DateTimeKind.Local).AddTicks(420), "lIybHLKKFglU/EfL+O5lzj4OiKc=", "FXkLZOWdoWTbMvYR/oTxoQ==" });
        }
    }
}
