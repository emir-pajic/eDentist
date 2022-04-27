using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eDentist.WebAPI.Migrations
{
    public partial class NullableManufacturerInMaterials : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Manufacturers_ManufacturerId",
                table: "Materials");

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturerId",
                table: "Materials",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 4, 27, 22, 27, 34, 495, DateTimeKind.Local).AddTicks(5470), "lhWC1yuP8N/hHTvCv28iPDe6mPU=", "XG42OO27kgCSQTzfG0wxfg==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 4, 27, 22, 27, 34, 502, DateTimeKind.Local).AddTicks(4212), "JkjktvZO0uXsZnwS5Xn2XUrmz+k=", "Z2qIV3BCs1JAoeFlWkFdBg==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Manufacturers_ManufacturerId",
                table: "Materials",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "ManufacturerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Manufacturers_ManufacturerId",
                table: "Materials");

            migrationBuilder.AlterColumn<int>(
                name: "ManufacturerId",
                table: "Materials",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 4, 25, 21, 41, 45, 297, DateTimeKind.Local).AddTicks(4280), "My8WRtMXoaAI4qnhVjSUb6DvvLE=", "l3zpKAz8XbzGr1jVWpy5XA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 4, 25, 21, 41, 45, 314, DateTimeKind.Local).AddTicks(4589), "Yx6h4IQz1H5qkFjqaNBUF4rbZMg=", "lVyhL6lUt1U111SSBxnI3A==" });

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Manufacturers_ManufacturerId",
                table: "Materials",
                column: "ManufacturerId",
                principalTable: "Manufacturers",
                principalColumn: "ManufacturerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
