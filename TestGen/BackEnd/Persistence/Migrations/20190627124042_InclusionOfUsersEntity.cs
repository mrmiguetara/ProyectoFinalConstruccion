using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class InclusionOfUsersEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    UserName = table.Column<string>(nullable: true),
                    NormalizedUserName = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    NormalizedEmail = table.Column<string>(nullable: true),
                    EmailConfirmed = table.Column<short>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<short>(nullable: false),
                    TwoFactorEnabled = table.Column<short>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<short>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Users");

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
                columns: new[] { "Created", "Updated" },
                values: new object[] { new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230), new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230) });

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
    }
}
