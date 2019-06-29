using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class userExamRelationship : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "UserId",
                table: "Exams",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(1190), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(1210) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 431, DateTimeKind.Local).AddTicks(6800), new DateTime(2019, 6, 28, 18, 50, 52, 441, DateTimeKind.Local).AddTicks(6380) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 441, DateTimeKind.Local).AddTicks(8350), new DateTime(2019, 6, 28, 18, 50, 52, 441, DateTimeKind.Local).AddTicks(8350) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 441, DateTimeKind.Local).AddTicks(8370), new DateTime(2019, 6, 28, 18, 50, 52, 441, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 441, DateTimeKind.Local).AddTicks(8370), new DateTime(2019, 6, 28, 18, 50, 52, 441, DateTimeKind.Local).AddTicks(8370) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(6260), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(6260) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8190), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8200) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8220), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8220), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8220) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8230), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8230), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8230) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8230), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8240), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8240), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8240) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8250), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8250), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8250) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8250), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8260), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8260), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8260) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8270), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8270) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8750), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8750) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8770), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8770), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8780), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8780), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8790), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8790), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8790), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8800), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8800), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8810), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8810), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8810), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8810) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8820), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(8820) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(3840), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(3850) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(4900), new DateTime(2019, 6, 28, 18, 50, 52, 444, DateTimeKind.Local).AddTicks(4910) });

            migrationBuilder.CreateIndex(
                name: "IX_Exams_UserId",
                table: "Exams",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Exams_Users_UserId",
                table: "Exams",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Exams_Users_UserId",
                table: "Exams");

            migrationBuilder.DropIndex(
                name: "IX_Exams_UserId",
                table: "Exams");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Exams");

            migrationBuilder.UpdateData(
                table: "Exams",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(3760), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(3770) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 278, DateTimeKind.Local).AddTicks(2920), new DateTime(2019, 6, 27, 8, 40, 42, 284, DateTimeKind.Local).AddTicks(9310) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 285, DateTimeKind.Local).AddTicks(340), new DateTime(2019, 6, 27, 8, 40, 42, 285, DateTimeKind.Local).AddTicks(350) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 285, DateTimeKind.Local).AddTicks(360), new DateTime(2019, 6, 27, 8, 40, 42, 285, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "QuestionTypes",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 285, DateTimeKind.Local).AddTicks(360), new DateTime(2019, 6, 27, 8, 40, 42, 285, DateTimeKind.Local).AddTicks(360) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(7350), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(7350) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8740), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8760), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8760), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8760) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8780), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8780), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8780) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8780), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8800) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9140), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9150) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9160), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9160), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9160), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9160) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9170), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9170), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9170), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9170) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9180), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9180), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9180), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9180) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9190), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9190), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9190), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9190) });

            migrationBuilder.UpdateData(
                table: "Questions",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9200), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9200) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(5580), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(5580) });

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(6380), new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(6390) });
        }
    }
}
