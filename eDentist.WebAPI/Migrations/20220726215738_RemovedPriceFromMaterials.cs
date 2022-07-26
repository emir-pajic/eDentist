using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentist.WebAPI.Migrations
{
    public partial class RemovedPriceFromMaterials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<byte[]>(
                name: "Image",
                table: "Materials",
                type: "varbinary(max)",
                nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Image",
                table: "Materials");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 7, 26, 17, 17, 26, 52, DateTimeKind.Local).AddTicks(4729), "JNwrnY56w8wjDDOHTrfiJtq+BKw=", "58xYpTxsWhQDQabBUgAr/A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 7, 26, 17, 17, 26, 57, DateTimeKind.Local).AddTicks(1232), "2JBFyhFGBbxsz7grU4Wl6jugTCI=", "RWYld+OmTGMiEjrjEmkp2g==" });
        }
    }
}
