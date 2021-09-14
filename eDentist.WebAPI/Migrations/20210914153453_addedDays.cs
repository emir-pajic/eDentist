using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace eDentist.WebAPI.Migrations
{
    public partial class addedDays : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Days",
                columns: new[] { "DayId", "Name" },
                values: new object[,]
                {
                    { 1, "Monday" },
                    { 2, "Tuesday" },
                    { 3, "Wednesday" },
                    { 4, "Thursday" },
                    { 5, "Friday" },
                    { 6, "Saturday" },
                    { 7, "Sunday" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 14, 17, 34, 52, 526, DateTimeKind.Local).AddTicks(7501), "tBhhEWPVEjfs2AW+27vJXukIxdY=", "/mGY/nNKSS9TuY7pGJbjUA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 14, 17, 34, 52, 540, DateTimeKind.Local).AddTicks(692), "HArO7THp6MX1GD6X20YPMC758YI=", "KfbHDtE4Ph9q3K3woiIgbA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "DayId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "DayId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "DayId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "DayId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "DayId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "DayId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Days",
                keyColumn: "DayId",
                keyValue: 7);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 13, 22, 8, 19, 355, DateTimeKind.Local).AddTicks(8645), "BRMUJpXcnaQVPR9nrIhGTjTdr/k=", "4xnQv7T6HwwHsTMqipfl9A==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2021, 9, 13, 22, 8, 19, 363, DateTimeKind.Local).AddTicks(2105), "vYsC6E0ZWTKWhUoPQn5w/Ap2bCc=", "LiluOiaEAMo9+inXkNsMlA==" });
        }
    }
}
