﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MirationEF10.Data;

#nullable disable

namespace MirationEF10.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230515124202_add-Fname-Lname")]
    partial class addFnameLname
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MirationEF10.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<decimal>("Price")
                        .HasPrecision(15, 2)
                        .HasColumnType("decimal(15,2)");

                    b.HasKey("Id");

                    b.ToTable("Courses", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseName = "Html",
                            Price = 1500m
                        },
                        new
                        {
                            Id = 2,
                            CourseName = "CSS",
                            Price = 1800m
                        },
                        new
                        {
                            Id = 3,
                            CourseName = "JS",
                            Price = 1000m
                        },
                        new
                        {
                            Id = 4,
                            CourseName = "C#",
                            Price = 2500m
                        });
                });

            modelBuilder.Entity("MirationEF10.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Instructors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "Yassmin",
                            LName = "Abdullah"
                        },
                        new
                        {
                            Id = 2,
                            FName = "YassminL",
                            LName = "mohammed"
                        },
                        new
                        {
                            Id = 3,
                            FName = "Khaled",
                            LName = "Ahmed"
                        },
                        new
                        {
                            Id = 4,
                            FName = "Sayed",
                            LName = "Mahros"
                        },
                        new
                        {
                            Id = 5,
                            FName = "Abdo",
                            LName = "Tarek"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
