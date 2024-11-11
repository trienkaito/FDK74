using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FBK74App.Migrations
{
    /// <inheritdoc />
    public partial class updatedateDB : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<TimeOnly>(
                name: "StartTime",
                table: "FootballFieldSchedules",
                type: "time",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<TimeOnly>(
                name: "EndTime",
                table: "FootballFieldSchedules",
                type: "time",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4395), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4408) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4411), "admin", new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4412), "admin" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4413), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4414) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Type", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4446), 0, new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4447) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4448), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4448) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PaymentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4660), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4659), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4660) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PaymentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4662), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4662), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4663) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PaymentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4664), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4664), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4665) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PaymentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4667), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4667), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4668) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PaymentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4669), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4669), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4670) });

            migrationBuilder.UpdateData(
                table: "FootballFieldSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4802), new TimeOnly(7, 30, 0), new TimeOnly(6, 30, 0), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4803) });

            migrationBuilder.UpdateData(
                table: "FootballFieldSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4805), new TimeOnly(8, 30, 0), new TimeOnly(7, 30, 0), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4806) });

            migrationBuilder.UpdateData(
                table: "FootballFieldSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4807), new TimeOnly(9, 30, 0), new TimeOnly(8, 30, 0), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4808) });

            migrationBuilder.UpdateData(
                table: "FootballFieldSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4810), new TimeOnly(10, 30, 0), new TimeOnly(9, 30, 0), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4810) });

            migrationBuilder.UpdateData(
                table: "FootballFieldSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4812), new TimeOnly(11, 30, 0), new TimeOnly(10, 30, 0), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4812) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4605), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4606) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4607), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4608) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4609), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4609) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4610), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4611) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4612), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4612) });

            migrationBuilder.UpdateData(
                table: "RegistFindOppoents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4739), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4736), new DateTime(2024, 10, 30, 12, 32, 57, 257, DateTimeKind.Local).AddTicks(4731), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4730), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4739) });

            migrationBuilder.UpdateData(
                table: "RegistFindOppoents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4743), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4742), new DateTime(2024, 10, 30, 12, 32, 57, 257, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4741), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4743) });

            migrationBuilder.UpdateData(
                table: "RegistFindOppoents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4746), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4746), new DateTime(2024, 10, 30, 12, 32, 57, 257, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4745), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4747) });

            migrationBuilder.UpdateData(
                table: "RegistFindOppoents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4752), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4751), new DateTime(2024, 10, 30, 12, 32, 57, 257, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4748), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4752) });

            migrationBuilder.UpdateData(
                table: "RegistFindOppoents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4755), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4754), new DateTime(2024, 10, 30, 12, 32, 57, 257, DateTimeKind.Local).AddTicks(4754), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4753), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4756) });

            migrationBuilder.UpdateData(
                table: "RegisteredFootballFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4700), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4698), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4700) });

            migrationBuilder.UpdateData(
                table: "RegisteredFootballFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4703), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4702), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4703) });

            migrationBuilder.UpdateData(
                table: "RegisteredFootballFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4705), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4705), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4706) });

            migrationBuilder.UpdateData(
                table: "RegisteredFootballFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4708), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4707), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4709) });

            migrationBuilder.UpdateData(
                table: "RegisteredFootballFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4711), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4710), new DateTime(2024, 10, 30, 10, 32, 57, 257, DateTimeKind.Local).AddTicks(4711) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "StartTime",
                table: "FootballFieldSchedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(TimeOnly),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "EndTime",
                table: "FootballFieldSchedules",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(TimeOnly),
                oldType: "time",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5231), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5243) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Password", "UpdatedDate", "UserName" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5247), "pass2", new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5248), "user2" });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5251), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5252) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Type", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5254), 1, new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5255) });

            migrationBuilder.UpdateData(
                table: "Accounts",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5257), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5258) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "PaymentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5752), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5751), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5753) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "PaymentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5757), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5756), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5758) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "PaymentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5761), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5760), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5762) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "PaymentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5764), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5763), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5765) });

            migrationBuilder.UpdateData(
                table: "Bills",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "PaymentDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5767), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5768) });

            migrationBuilder.UpdateData(
                table: "FootballFieldSchedules",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5979), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5978), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5977), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5980) });

            migrationBuilder.UpdateData(
                table: "FootballFieldSchedules",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5984), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5983), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5982), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5985) });

            migrationBuilder.UpdateData(
                table: "FootballFieldSchedules",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5989), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5988), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5987), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5990) });

            migrationBuilder.UpdateData(
                table: "FootballFieldSchedules",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5993), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5992), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5991), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5994) });

            migrationBuilder.UpdateData(
                table: "FootballFieldSchedules",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5997), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5996), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5995), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5998) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5595), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5596) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5599), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5600) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5602), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5603) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5605), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5605) });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5607), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5608) });

            migrationBuilder.UpdateData(
                table: "RegistFindOppoents",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5881), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5878), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5870), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5869), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5882) });

            migrationBuilder.UpdateData(
                table: "RegistFindOppoents",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5888), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5886), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5885), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5884), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5889) });

            migrationBuilder.UpdateData(
                table: "RegistFindOppoents",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5896), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5894), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5893), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5892), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5897) });

            migrationBuilder.UpdateData(
                table: "RegistFindOppoents",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5903), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5901), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5900), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5899), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5903) });

            migrationBuilder.UpdateData(
                table: "RegistFindOppoents",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "EndTime", "StartTime", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5909), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5907), new DateTime(2024, 10, 28, 1, 32, 39, 855, DateTimeKind.Local).AddTicks(5906), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5905), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5909) });

            migrationBuilder.UpdateData(
                table: "RegisteredFootballFields",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "CreatedDate", "Date", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5809), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5807), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5810) });

            migrationBuilder.UpdateData(
                table: "RegisteredFootballFields",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "CreatedDate", "Date", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5815), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5814), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5816) });

            migrationBuilder.UpdateData(
                table: "RegisteredFootballFields",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "CreatedDate", "Date", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5820), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5819), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5821) });

            migrationBuilder.UpdateData(
                table: "RegisteredFootballFields",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "CreatedDate", "Date", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5825), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5824), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5825) });

            migrationBuilder.UpdateData(
                table: "RegisteredFootballFields",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "CreatedDate", "Date", "UpdatedDate" },
                values: new object[] { new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5830), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5828), new DateTime(2024, 10, 27, 23, 32, 39, 855, DateTimeKind.Local).AddTicks(5831) });
        }
    }
}
