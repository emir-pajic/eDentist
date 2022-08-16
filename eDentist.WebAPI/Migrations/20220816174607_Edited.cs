using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentist.WebAPI.Migrations
{
    public partial class Edited : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 8, 16, 19, 46, 6, 867, DateTimeKind.Local).AddTicks(3666), "LH3EQ25cDnOhrI1eiAWV2LEJwYs=", "kVEoSAGETrjjrMy1pbuTaA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 8, 16, 19, 46, 6, 871, DateTimeKind.Local).AddTicks(410), "limkjcav+Crk0qpDHGMkk4aHcR4=", "Rb0ysVzETezBKkdLY+aC5g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 8, 16, 19, 44, 28, 204, DateTimeKind.Local).AddTicks(2982), "Cz1wmm950WoVZfRkRwo1soSDaY8=", "uGFze6A2FTj9IzE7edkNGg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 8, 16, 19, 44, 28, 207, DateTimeKind.Local).AddTicks(9311), "6z22Xd6e1xAjl6RSiewKP/WLFBQ=", "Owv4xxEIiPg+4S7+ksLiBQ==" });
        }
    }
}
