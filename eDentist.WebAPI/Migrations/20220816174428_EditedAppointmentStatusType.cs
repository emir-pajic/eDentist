using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace eDentist.WebAPI.Migrations
{
    public partial class EditedAppointmentStatusType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "TreatmentId",
            //    table: "Examinations",
            //    type: "int",
            //    nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TreatmentId",
                table: "Examinations");

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
    }
}
