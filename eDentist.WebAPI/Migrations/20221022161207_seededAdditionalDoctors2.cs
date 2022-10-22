using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.WebAPI.Migrations
{
    public partial class seededAdditionalDoctors2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "UserRoleId", "RoleId", "UserId" },
                values: new object[,]
                {
                    { 6, 3, 7 },
                    { 7, 3, 5 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 18, 12, 7, 321, DateTimeKind.Local).AddTicks(8472), "l3iSeLxCK1ex9TzTbNj9cDbRh+s=", "nvR+zW9sbYZ6FvrwYKOe+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 18, 12, 7, 321, DateTimeKind.Local).AddTicks(9459), "sZXgNReRiOXhNYUh1H3qDFP+mYE=", "nvR+zW9sbYZ6FvrwYKOe+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 18, 12, 7, 322, DateTimeKind.Local).AddTicks(1666), "sZXgNReRiOXhNYUh1H3qDFP+mYE=", "nvR+zW9sbYZ6FvrwYKOe+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 18, 12, 7, 322, DateTimeKind.Local).AddTicks(2148), "sZXgNReRiOXhNYUh1H3qDFP+mYE=", "nvR+zW9sbYZ6FvrwYKOe+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 18, 12, 7, 321, DateTimeKind.Local).AddTicks(9180), "sZXgNReRiOXhNYUh1H3qDFP+mYE=", "nvR+zW9sbYZ6FvrwYKOe+A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 18, 12, 7, 322, DateTimeKind.Local).AddTicks(2366), "sZXgNReRiOXhNYUh1H3qDFP+mYE=", "nvR+zW9sbYZ6FvrwYKOe+A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumn: "UserRoleId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 18, 4, 7, 15, DateTimeKind.Local).AddTicks(8809), "BoGPpHkrPAKJjKpsfs5Da1LkCJU=", "P1KowJEBsy0nCQWY2jxRlw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 18, 4, 7, 15, DateTimeKind.Local).AddTicks(9619), "wYoRNlAuTvEQU2cTjduEJtpO1kE=", "P1KowJEBsy0nCQWY2jxRlw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 18, 4, 7, 16, DateTimeKind.Local).AddTicks(990), "wYoRNlAuTvEQU2cTjduEJtpO1kE=", "P1KowJEBsy0nCQWY2jxRlw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 5,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 18, 4, 7, 16, DateTimeKind.Local).AddTicks(1303), "wYoRNlAuTvEQU2cTjduEJtpO1kE=", "P1KowJEBsy0nCQWY2jxRlw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 18, 4, 7, 15, DateTimeKind.Local).AddTicks(9346), "wYoRNlAuTvEQU2cTjduEJtpO1kE=", "P1KowJEBsy0nCQWY2jxRlw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 7,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 22, 18, 4, 7, 16, DateTimeKind.Local).AddTicks(1522), "wYoRNlAuTvEQU2cTjduEJtpO1kE=", "P1KowJEBsy0nCQWY2jxRlw==" });
        }
    }
}
