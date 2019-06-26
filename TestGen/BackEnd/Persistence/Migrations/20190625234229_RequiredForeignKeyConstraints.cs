using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class RequiredForeignKeyConstraints : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 725, DateTimeKind.Local).AddTicks(8140), new DateTime(2019, 6, 25, 19, 42, 28, 725, DateTimeKind.Local).AddTicks(8150) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 717, DateTimeKind.Local).AddTicks(7120), new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(3710) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(4720), new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(4730) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(4730), new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(4740), new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(4740) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(1820), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(1820) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3200), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3200) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3220), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3220), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3220) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Answer", "Created", "Updated" },
                values: new object[] { "false", new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3260) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3600), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3600) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3610), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3610) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3610), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3650), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3650) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(20), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(20) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(770), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(770) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 570, DateTimeKind.Local).AddTicks(7010), new DateTime(2019, 6, 23, 22, 20, 16, 570, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 562, DateTimeKind.Local).AddTicks(8520), new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(2500) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(3430), new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(3430) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(3440), new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(3440) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(3450), new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(3450) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(350), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1660), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1670) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1680), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1680) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Answer", "Created", "Updated" },
                values: new object[] { "falso", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1720), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1720) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2040), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2040) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2050), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2050), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2050) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2080), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2080), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2080), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2080) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2130), new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2130) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 570, DateTimeKind.Local).AddTicks(8730), new DateTime(2019, 6, 23, 22, 20, 16, 570, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 23, 22, 20, 16, 570, DateTimeKind.Local).AddTicks(9440), new DateTime(2019, 6, 23, 22, 20, 16, 570, DateTimeKind.Local).AddTicks(9440) });
        }
    }
}
