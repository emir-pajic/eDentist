using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.WebAPI.Migrations
{
    public partial class seedtestappointment : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AcceptedById", "AppointmentStatus", "Date", "DayId", "PreferedDoctorId", "Status", "UserId" },
                values: new object[] { 1, null, "Requested", new DateTime(2022, 11, 10, 17, 0, 0, 0, DateTimeKind.Unspecified), null, 4, false, 3 });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 21, 11, 50, 623, DateTimeKind.Local).AddTicks(6674), "hYqiMjF7BbETBbeeiuKw6qZQ/Oo=", "h8jrvg3y2iuPR9MFBrrdGQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 21, 11, 50, 623, DateTimeKind.Local).AddTicks(7374), "FD+VNZ6KVetNEU+390ub+Mw/Fuk=", "h8jrvg3y2iuPR9MFBrrdGQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 21, 11, 50, 623, DateTimeKind.Local).AddTicks(7566), "FD+VNZ6KVetNEU+390ub+Mw/Fuk=", "h8jrvg3y2iuPR9MFBrrdGQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 21, 11, 50, 623, DateTimeKind.Local).AddTicks(7145), "FD+VNZ6KVetNEU+390ub+Mw/Fuk=", "h8jrvg3y2iuPR9MFBrrdGQ==" });
        }
    }
}
