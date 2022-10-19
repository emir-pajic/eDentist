using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.WebAPI.Migrations
{
    public partial class seededexaminationtest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Appointments",
                columns: new[] { "AppointmentId", "AcceptedById", "AppointmentStatus", "Date", "DayId", "PreferedDoctorId", "Status", "UserId" },
                values: new object[,]
                {
                    { 6, 4, "Accepted", new DateTime(2022, 12, 13, 9, 45, 0, 0, DateTimeKind.Unspecified), null, 4, false, 3 },
                    { 7, 4, "Accepted", new DateTime(2022, 12, 23, 12, 45, 0, 0, DateTimeKind.Unspecified), null, 4, false, 3 },
                    { 8, 4, "Accepted", new DateTime(2022, 12, 18, 10, 45, 0, 0, DateTimeKind.Unspecified), null, 4, false, 3 }
                });

            migrationBuilder.InsertData(
                table: "Examinations",
                columns: new[] { "ExaminationId", "AdditionalInfo", "AppointmentId", "PaymentTokenId", "Status", "TreatmentId", "TreatmentsMaterialsId", "UserId" },
                values: new object[] { 1, "vadjenje zuba", 4, null, "Uspjesno", 6, null, 4 });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 21, 55, 787, DateTimeKind.Local).AddTicks(1205), "vJX3RYD57tMYi8eIo+/JQ7pYB6E=", "3qnoAfkmPVm8RXM9vxafcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 21, 55, 787, DateTimeKind.Local).AddTicks(1873), "UFi6ri9b9sQolTfarQFrgNgklYk=", "3qnoAfkmPVm8RXM9vxafcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 21, 55, 787, DateTimeKind.Local).AddTicks(2071), "UFi6ri9b9sQolTfarQFrgNgklYk=", "3qnoAfkmPVm8RXM9vxafcQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 21, 55, 787, DateTimeKind.Local).AddTicks(1641), "UFi6ri9b9sQolTfarQFrgNgklYk=", "3qnoAfkmPVm8RXM9vxafcQ==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Appointments",
                keyColumn: "AppointmentId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Examinations",
                keyColumn: "ExaminationId",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 17, 8, 680, DateTimeKind.Local).AddTicks(4348), "9C690JROW/0YMvKSLoW/+LKP2fU=", "SU1Fc4OKPnVmuCr44YWXQQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 3,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 17, 8, 680, DateTimeKind.Local).AddTicks(5056), "ZQKmSX2AMpVxzeIDR4MmLP1X0aI=", "SU1Fc4OKPnVmuCr44YWXQQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 4,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 17, 8, 680, DateTimeKind.Local).AddTicks(5274), "ZQKmSX2AMpVxzeIDR4MmLP1X0aI=", "SU1Fc4OKPnVmuCr44YWXQQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 6,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 22, 17, 8, 680, DateTimeKind.Local).AddTicks(4798), "ZQKmSX2AMpVxzeIDR4MmLP1X0aI=", "SU1Fc4OKPnVmuCr44YWXQQ==" });
        }
    }
}
