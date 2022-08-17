using Microsoft.EntityFrameworkCore.Migrations;
using System;

namespace eDentist.WebAPI.Migrations
{
    public partial class AddedNewFieldToAppointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.AddColumn<int>(
            //    name: "AcceptedById",
            //    table: "Appointments",
            //    type: "int",
            //    nullable: true);

            //migrationBuilder.AddColumn<string>(
            //    name: "AppointmentStatus",
            //    table: "Appointments",
            //    type: "nvarchar(max)",
            //    nullable: true);

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            //migrationBuilder.DropColumn(
            //    name: "AcceptedById",
            //    table: "Appointments");

            migrationBuilder.DropColumn(
                name: "AppointmentStatus",
                table: "Appointments");

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
    }
}
