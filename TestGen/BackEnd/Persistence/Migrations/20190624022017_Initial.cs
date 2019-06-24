using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Persistence.Migrations
{
    public partial class Initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Exams",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Subject = table.Column<string>(nullable: true),
                    Teacher = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Exams", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "QuestionTypes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Type = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_QuestionTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sections",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Instruction = table.Column<string>(nullable: false),
                    ExamId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Sections_Exams_ExamId",
                        column: x => x.ExamId,
                        principalTable: "Exams",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Questions",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("MySQL:AutoIncrement", true),
                    Created = table.Column<DateTime>(nullable: false),
                    Updated = table.Column<DateTime>(nullable: false),
                    Title = table.Column<string>(nullable: false),
                    Options = table.Column<string>(nullable: true),
                    QuestionTypeId = table.Column<int>(nullable: false),
                    Answer = table.Column<string>(nullable: true),
                    SectionId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Questions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Questions_QuestionTypes_QuestionTypeId",
                        column: x => x.QuestionTypeId,
                        principalTable: "QuestionTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Questions_Sections_SectionId",
                        column: x => x.SectionId,
                        principalTable: "Sections",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Exams",
                columns: new[] { "Id", "Created", "Subject", "Teacher", "Updated" },
                values: new object[] { 1, new DateTime(2019, 6, 23, 22, 20, 16, 570, DateTimeKind.Local).AddTicks(7010), "Historia", "Kakin", new DateTime(2019, 6, 23, 22, 20, 16, 570, DateTimeKind.Local).AddTicks(7020) });

            migrationBuilder.InsertData(
                table: "QuestionTypes",
                columns: new[] { "Id", "Created", "Type", "Updated" },
                values: new object[,]
                {
                    { 1, new DateTime(2019, 6, 23, 22, 20, 16, 562, DateTimeKind.Local).AddTicks(8520), "Verdadero o Falso", new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(2500) },
                    { 2, new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(3430), "Seleccion Multiple", new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(3430) },
                    { 3, new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(3440), "Seleccion Simple", new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(3440) },
                    { 4, new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(3450), "Completa", new DateTime(2019, 6, 23, 22, 20, 16, 569, DateTimeKind.Local).AddTicks(3450) }
                });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Created", "ExamId", "Instruction", "Updated" },
                values: new object[] { 1, new DateTime(2019, 6, 23, 22, 20, 16, 570, DateTimeKind.Local).AddTicks(8730), 1, "Escriba si es verdadero o falso", new DateTime(2019, 6, 23, 22, 20, 16, 570, DateTimeKind.Local).AddTicks(8740) });

            migrationBuilder.InsertData(
                table: "Sections",
                columns: new[] { "Id", "Created", "ExamId", "Instruction", "Updated" },
                values: new object[] { 2, new DateTime(2019, 6, 23, 22, 20, 16, 570, DateTimeKind.Local).AddTicks(9440), 1, "Eliga la respuesta correcta", new DateTime(2019, 6, 23, 22, 20, 16, 570, DateTimeKind.Local).AddTicks(9440) });

            migrationBuilder.InsertData(
                table: "Questions",
                columns: new[] { "Id", "Answer", "Created", "Options", "QuestionTypeId", "SectionId", "Title", "Updated" },
                values: new object[,]
                {
                    { 1, "true", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(350), null, 1, 1, "Yo soy verdadero", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(360) },
                    { 27, "d", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2080), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2080) },
                    { 26, "a", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2080), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2080) },
                    { 25, "a", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070) },
                    { 24, "a", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070) },
                    { 23, "b", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070) },
                    { 22, "a", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2070) },
                    { 21, "d", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060) },
                    { 20, "c", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060) },
                    { 19, "b", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2060) },
                    { 18, "a", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2050), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2050) },
                    { 17, "d", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2050), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2050) },
                    { 16, "a", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2040), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2040) },
                    { 28, "c", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2080), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2080) },
                    { 15, "a", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1720), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1720) },
                    { 13, "false", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710), null, 1, 1, "Yo soy falso", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710) },
                    { 12, "true", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710), null, 1, 1, "Yo soy verdadero", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710) },
                    { 11, "true", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700), null, 1, 1, "Yo soy verdadero", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710) },
                    { 10, "true", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700), null, 1, 1, "Yo soy verdadero", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700) },
                    { 9, "false", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700), null, 1, 1, "Yo soy falso", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700) },
                    { 8, "true", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700), null, 1, 1, "Yo soy verdadero", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1700) },
                    { 7, "false", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690), null, 1, 1, "Yo soy falso", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690) },
                    { 6, "false", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690), null, 1, 1, "Yo soy falso", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690) },
                    { 5, "false", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690), null, 1, 1, "Yo soy falso", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690) },
                    { 4, "true", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690), null, 1, 1, "Yo soy verdadero", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1690) },
                    { 3, "true", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1680), null, 1, 1, "Yo soy verdadero", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1680) },
                    { 2, "true", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1660), null, 1, 1, "Yo soy verdadero", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1670) },
                    { 14, "false", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710), null, 1, 1, "Yo soy falso", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(1710) },
                    { 29, "b", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2130), "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}", 2, 2, "Que letra es la correcta", new DateTime(2019, 6, 23, 22, 20, 16, 571, DateTimeKind.Local).AddTicks(2130) }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Questions_QuestionTypeId",
                table: "Questions",
                column: "QuestionTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Questions_SectionId",
                table: "Questions",
                column: "SectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Sections_ExamId",
                table: "Sections",
                column: "ExamId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Questions");

            migrationBuilder.DropTable(
                name: "QuestionTypes");

            migrationBuilder.DropTable(
                name: "Sections");

            migrationBuilder.DropTable(
                name: "Exams");
        }
    }
}
