﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Api.Migrations
{
    [DbContext(typeof(GeneratorDbContext))]
    [Migration("20190623211529_InitialTestMigration")]
    partial class InitialTestMigration
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
                });
#pragma warning restore 612, 618
        }
    }
}