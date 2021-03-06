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
    [Migration("20190627124042_InclusionOfUsersEntity")]
    partial class InclusionOfUsersEntity
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity("Core.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp");

                    b.Property<string>("Email");

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail");

                    b.Property<string>("NormalizedUserName");

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

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
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(3760),
                            Subject = "Historia",
                            Teacher = "Kakin",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(3770)
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
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(7350),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(7350)
                        },
                        new
                        {
                            Id = 2,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8740),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8740)
                        },
                        new
                        {
                            Id = 3,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8760),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8760)
                        },
                        new
                        {
                            Id = 4,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8760),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8760)
                        },
                        new
                        {
                            Id = 5,
                            Answer = "false",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy falso",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770)
                        },
                        new
                        {
                            Id = 6,
                            Answer = "false",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy falso",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770)
                        },
                        new
                        {
                            Id = 7,
                            Answer = "false",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy falso",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770)
                        },
                        new
                        {
                            Id = 8,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8770),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8780)
                        },
                        new
                        {
                            Id = 9,
                            Answer = "false",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8780),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy falso",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8780)
                        },
                        new
                        {
                            Id = 10,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8780),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8780)
                        },
                        new
                        {
                            Id = 11,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8780),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790)
                        },
                        new
                        {
                            Id = 12,
                            Answer = "true",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy verdadero",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790)
                        },
                        new
                        {
                            Id = 13,
                            Answer = "false",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy falso",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790)
                        },
                        new
                        {
                            Id = 14,
                            Answer = "false",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790),
                            QuestionTypeId = 1,
                            SectionId = 1,
                            Title = "Yo soy falso",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790)
                        },
                        new
                        {
                            Id = 15,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8790),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(8800)
                        },
                        new
                        {
                            Id = 16,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9140),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9150)
                        },
                        new
                        {
                            Id = 17,
                            Answer = "d",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9160),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9160)
                        },
                        new
                        {
                            Id = 18,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9160),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9160)
                        },
                        new
                        {
                            Id = 19,
                            Answer = "b",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9160),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9160)
                        },
                        new
                        {
                            Id = 20,
                            Answer = "c",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9170),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9170)
                        },
                        new
                        {
                            Id = 21,
                            Answer = "d",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9170),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9170)
                        },
                        new
                        {
                            Id = 22,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9170),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9170)
                        },
                        new
                        {
                            Id = 23,
                            Answer = "b",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9180),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9180)
                        },
                        new
                        {
                            Id = 24,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9180),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9180)
                        },
                        new
                        {
                            Id = 25,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9180),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9180)
                        },
                        new
                        {
                            Id = 26,
                            Answer = "a",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9190),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9190)
                        },
                        new
                        {
                            Id = 27,
                            Answer = "d",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9190),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9190)
                        },
                        new
                        {
                            Id = 28,
                            Answer = "c",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9190),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9190)
                        },
                        new
                        {
                            Id = 29,
                            Answer = "b",
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9200),
                            Options = "{a: \"Opcion a \", b: \"Opcion b \", c: \"Opcion c \", d: \"Opcion d \"}",
                            QuestionTypeId = 2,
                            SectionId = 2,
                            Title = "Que letra es la correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(9200)
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
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 278, DateTimeKind.Local).AddTicks(2920),
                            Type = "Verdadero o Falso",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 284, DateTimeKind.Local).AddTicks(9310)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 285, DateTimeKind.Local).AddTicks(340),
                            Type = "Seleccion Multiple",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 285, DateTimeKind.Local).AddTicks(350)
                        },
                        new
                        {
                            Id = 3,
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 285, DateTimeKind.Local).AddTicks(360),
                            Type = "Seleccion Simple",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 285, DateTimeKind.Local).AddTicks(360)
                        },
                        new
                        {
                            Id = 4,
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 285, DateTimeKind.Local).AddTicks(360),
                            Type = "Completa",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 285, DateTimeKind.Local).AddTicks(360)
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
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(5580),
                            ExamId = 1,
                            Instruction = "Escriba si es verdadero o falso",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(5580)
                        },
                        new
                        {
                            Id = 2,
                            Created = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(6380),
                            ExamId = 1,
                            Instruction = "Eliga la respuesta correcta",
                            Updated = new DateTime(2019, 6, 27, 8, 40, 42, 286, DateTimeKind.Local).AddTicks(6390)
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
