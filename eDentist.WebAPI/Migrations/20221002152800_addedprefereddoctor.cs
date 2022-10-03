using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.WebAPI.Migrations
{
    public partial class addedprefereddoctor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PreferedDoctorId",
                table: "Appointments",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 2, 17, 28, 0, 146, DateTimeKind.Local).AddTicks(6160), "LEuwOvuXWvTQMV2t9A4lBUpFRWg=", "MjRBG2Audu6LKGe1FXziUw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 2, 17, 28, 0, 146, DateTimeKind.Local).AddTicks(7199), "Y+VvOR8gsr0cc/9sOTLaVCy7/OQ=", "wIx6DT5w/QkrVRKcou8fDA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "PreferedDoctorId",
                table: "Appointments");

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
    }
}
