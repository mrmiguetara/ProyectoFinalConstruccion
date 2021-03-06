﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations
{
    [DbContext(typeof(GeneratorDbContext))]
    [Migration("20190625234229_RequiredForeignKeyConstraints")]
    partial class RequiredForeignKeyConstraints
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Core.Models.Exam", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Subject");

                    b.Property<string>("Teacher");

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("Exams");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 725, DateTimeKind.Local).AddTicks(8140),
                            Subject = "Historia",
                            Teacher = "Kakin",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 725, DateTimeKind.Local).AddTicks(8150)
                        });
                });

            modelBuilder.Entity("Core.Models.Question", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Options");

                    b.Property<int>("QuestionTypeId");

                    b.Property<int>("SectionId");

                    b.Property<string>("Title")
                        .IsRequired();

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("QuestionTypeId");

                    b.HasIndex("SectionId");

                    b.ToTable("Questions");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(1820),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(1820)
                        },
                        new
                        {
                            Id = 2,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3200),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3200)
                        },
                        new
                        {
                            Id = 3,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3220),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3220)
                        },
                        new
                        {
                            Id = 4,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3220),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3220)
                        },
                        new
                        {
                            Id = 5,
                            Answer = "false",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy falso",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230)
                        },
                        new
                        {
                            Id = 6,
                            Answer = "false",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy falso",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230)
                        },
                        new
                        {
                            Id = 7,
                            Answer = "false",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy falso",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230)
                        },
                        new
                        {
                            Id = 8,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3230),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240)
                        },
                        new
                        {
                            Id = 9,
                            Answer = "false",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy falso",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240)
                        },
                        new
                        {
                            Id = 10,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240)
                        },
                        new
                        {
                            Id = 11,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3240)
                        },
                        new
                        {
                            Id = 12,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250)
                        },
                        new
                        {
                            Id = 13,
                            Answer = "false",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy falso",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250)
                        },
                        new
                        {
                            Id = 14,
                            Answer = "false",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy falso",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250)
                        },
                        new
                        {
                            Id = 15,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3250),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3260)
                        },
                        new
                        {
                            Id = 16,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3600),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3600)
                        },
                        new
                        {
                            Id = 17,
                            Answer = "d",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3610),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3610)
                        },
                        new
                        {
                            Id = 18,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3610),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620)
                        },
                        new
                        {
                            Id = 19,
                            Answer = "b",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620)
                        },
                        new
                        {
                            Id = 20,
                            Answer = "c",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620)
                        },
                        new
                        {
                            Id = 21,
                            Answer = "d",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3620)
                        },
                        new
                        {
                            Id = 22,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630)
                        },
                        new
                        {
                            Id = 23,
                            Answer = "b",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630)
                        },
                        new
                        {
                            Id = 24,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630)
                        },
                        new
                        {
                            Id = 25,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3630),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640)
                        },
                        new
                        {
                            Id = 26,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640)
                        },
                        new
                        {
                            Id = 27,
                            Answer = "d",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640)
                        },
                        new
                        {
                            Id = 28,
                            Answer = "c",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3640)
                        },
                        new
                        {
                            Id = 29,
                            Answer = "b",
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3650),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(3650)
                        });
                });

            modelBuilder.Entity("Core.Models.QuestionType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<string>("Type")
                        .IsRequired();

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.ToTable("QuestionTypes");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 717, DateTimeKind.Local).AddTicks(7120),
                            Type = "Verdadero o Falso",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(3710)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(4720),
                            Type = "Seleccion Multiple",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(4730)
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(4730),
                            Type = "Seleccion Simple",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(4740)
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(4740),
                            Type = "Completa",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 724, DateTimeKind.Local).AddTicks(4740)
                        });
                });

            modelBuilder.Entity("Core.Models.Section", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<int>("ExamId");

                    b.Property<string>("Instruction")
                        .IsRequired();

                    b.Property<DateTime>("Updated");

                    b.HasKey("Id");

                    b.HasIndex("ExamId");

                    b.ToTable("Sections");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(20),
                            ExamId = 1,
                            Instruction = "Escriba si es verdadero o falso",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(20)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(770),
                            ExamId = 1,
                            Instruction = "Eliga la respuesta correcta",
                            Updated = new DateTime(2019, 6, 25, 19, 42, 28, 726, DateTimeKind.Local).AddTicks(770)
                        });
                });

            modelBuilder.Entity("Core.Models.Question", b =>
                {
                    b.HasOne("Core.Models.QuestionType", "QuestionType")
                        .WithMany("Questions")
                        .HasForeignKey("QuestionTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Models.Section", "Section")
                        .WithMany("Questions")
                        .HasForeignKey("SectionId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Core.Models.Section", b =>
                {
                    b.HasOne("Core.Models.Exam", "Exam")
                        .WithMany("Sections")
                        .HasForeignKey("ExamId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
