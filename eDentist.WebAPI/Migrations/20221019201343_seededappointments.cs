using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.WebAPI.Migrations
{
    public partial class seededappointments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AcceptedById", "AppointmentStatus", "Date", "DayId", "PreferedDoctorId", "Status", "UserId" },
                values: new object[,]
                {
                    { 2, null, "Requested", new DateTime(2022, 10, 31, 11, 30, 0, 0, DateTimeKind.Unspecified), null, 4, false, 3 },
                    { 3, null, "Requested", new DateTime(2023, 1, 3, 14, 15, 0, 0, DateTimeKind.Unspecified), null, 4, false, 3 },
                    { 4, 4, "Accepted", new DateTime(2022, 12, 13, 12, 45, 0, 0, DateTimeKind.Unspecified), null, 4, false, 3 },
                    { 5, null, "Requested", new DateTime(2022, 11, 22, 15, 15, 0, 0, DateTimeKind.Unspecified), null, 4, false, 3 }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 13, 43, 414, DateTimeKind.Local).AddTicks(1116), "Jt8DGkk9x9IQT9/gQlDSVut4a3w=", "p6U3pNMXE7zehteHKajJHg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 13, 43, 414, DateTimeKind.Local).AddTicks(2523), "oVSP9ZZzJsxKrEzhuewumMmTICQ=", "p6U3pNMXE7zehteHKajJHg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 13, 43, 414, DateTimeKind.Local).AddTicks(3653), "oVSP9ZZzJsxKrEzhuewumMmTICQ=", "p6U3pNMXE7zehteHKajJHg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 13, 43, 414, DateTimeKind.Local).AddTicks(1961), "oVSP9ZZzJsxKrEzhuewumMmTICQ=", "p6U3pNMXE7zehteHKajJHg==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 5);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 21, 52, 47, 332, DateTimeKind.Local).AddTicks(2450), "OuVkJ+qr+HA05hzzN13t4tYtoys=", "dNeY4dk7gGlAHfT2GwPsjA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 21, 52, 47, 332, DateTimeKind.Local).AddTicks(3146), "Torti1xNpuSIIMlRI21XfTEDvS0=", "dNeY4dk7gGlAHfT2GwPsjA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 21, 52, 47, 332, DateTimeKind.Local).AddTicks(3370), "Torti1xNpuSIIMlRI21XfTEDvS0=", "dNeY4dk7gGlAHfT2GwPsjA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 21, 52, 47, 332, DateTimeKind.Local).AddTicks(2940), "Torti1xNpuSIIMlRI21XfTEDvS0=", "dNeY4dk7gGlAHfT2GwPsjA==" });
        }
    }
}
