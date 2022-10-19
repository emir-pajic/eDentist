using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace eDentist.WebAPI.Migrations
{
    public partial class seededcountries : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "CountryId", "CountryName" },
                values: new object[,]
                {
                    { 2, "Croatia" },
                    { 3, "Serbia" },
                    { 4, "Montenegro" },
                    { 5, "Turkey" },
                    { 6, "Slovenia" },
                    { 7, "Spain" },
                    { 8, "France" },
                    { 9, "Germany" },
                    { 10, "Denmark" }
                });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 15, 4, 5, 873, DateTimeKind.Local).AddTicks(3105), "gDHvs9NHO3oTca3GOGMTt1TiEiE=", "b3EcPQLbD1llN9XxbMhgYA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 15, 4, 5, 873, DateTimeKind.Local).AddTicks(3602), "DtU9BtxC6S8be2+6l2rHNZeP+Kg=", "IBrvjvcGWikXLXLzNozdXA==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 1,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 0, 3, 30, 35, DateTimeKind.Local).AddTicks(5088), "DAfY/1o1FFqwq/J4z+IehWOLn5o=", "6GiA8G3GNROp5xaVb2N5OQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "UserId",
                keyValue: 2,
                columns: new[] { "DateOfBirth", "PasswordHash", "PasswordSalt" },
                values: new object[] { new DateTime(2022, 10, 19, 0, 3, 30, 35, DateTimeKind.Local).AddTicks(5578), "5FkI7VGmHe4tQxRD/FjbZ5+FvLg=", "ECSMh0tub/PKVCohY4jg2g==" });
        }
    }
}
