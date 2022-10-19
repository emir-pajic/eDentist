using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.WebAPI.Migrations
{
    public partial class seededtreatments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Treatments",
                columns: new[] { "TreatmentId", "Description", "Price" },
                values: new object[,]
                {
                    { 2, "Ugradnja plombe", 50.0 },
                    { 3, "Izbjeljivanje zuba", 100.0 },
                    { 4, "Ugradnja zastitnih navlaka", 80.0 },
                    { 5, "Ugradnja implantata", 1000.0 },
                    { 6, "Vadjenje zuba", 30.0 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 20, 58, 3, 362, DateTimeKind.Local).AddTicks(7783), "Ev05vEDfHjx7HGUN327iJfrXJYM=", "0uVojuVuuLYcx4ZnxjFnVQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "TreatmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "TreatmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "TreatmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "TreatmentId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Treatments",
                keyColumn: "TreatmentId",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 20, 39, 30, 27, DateTimeKind.Local).AddTicks(8820), "urFfuhLpcDXmXEoqm+aYUy16tHU=", "Ve7NUmR3r59bwz9o37LWmA==" });
        }
    }
}
