using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentist.WebAPI.Migrations
{
    public partial class AddedPriceToTreatment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "Price",
                table: "Treatments",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Price",
                table: "Treatments");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 7, 26, 17, 11, 28, 95, DateTimeKind.Local).AddTicks(8575), "RQY0FT+a5zwjnqswf6tV3Od0xeQ=", "hAz8CL/+NKTiutd9hbpt1A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 7, 26, 17, 11, 28, 100, DateTimeKind.Local).AddTicks(2166), "tTk1lIDXj8ZqumLpSyEHYGhHBVY=", "BsijAM1f5ldOlbIpb3zPEQ==" });
        }
    }
}
