﻿// <auto-generated />
using System;
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
    [Migration("20230515161801_Add-section-Entity-with-Relation-one-to-Many")]
    partial class AddsectionEntitywithRelationonetoMany
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
                        },
                        new
                        {
                            Id = 5,
                            CourseName = "C++",
                            Price = 2200m
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

                    b.Property<int?>("OfficeId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OfficeId")
                        .IsUnique()
                        .HasFilter("[OfficeId] IS NOT NULL");

                    b.ToTable("Instructors", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FName = "Yassmin",
                            LName = "Abdullah",
                            OfficeId = 1
                        },
                        new
                        {
                            Id = 2,
                            FName = "YassminL",
                            LName = "mohammed",
                            OfficeId = 2
                        },
                        new
                        {
                            Id = 3,
                            FName = "Khaled",
                            LName = "Ahmed",
                            OfficeId = 3
                        },
                        new
                        {
                            Id = 4,
                            FName = "Sayed",
                            LName = "Mahros",
                            OfficeId = 4
                        },
                        new
                        {
                            Id = 5,
                            FName = "Abdo",
                            LName = "Tarek",
                            OfficeId = 5
                        });
                });

            modelBuilder.Entity("MirationEF10.Entities.Office", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("OfficeLocation")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.Property<string>("OfficeName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.ToTable("Offices", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OfficeLocation = "Building A",
                            OfficeName = "CS"
                        },
                        new
                        {
                            Id = 2,
                            OfficeLocation = "Building B",
                            OfficeName = "IT"
                        },
                        new
                        {
                            Id = 3,
                            OfficeLocation = "Building C",
                            OfficeName = "SE"
                        },
                        new
                        {
                            Id = 4,
                            OfficeLocation = "Building D",
                            OfficeName = "IS"
                        },
                        new
                        {
                            Id = 5,
                            OfficeLocation = "Building E",
                            OfficeName = "IS"
                        });
                });

            modelBuilder.Entity("MirationEF10.Entities.Section", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("SectionName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("VARCHAR");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.HasIndex("InstructorId");

                    b.ToTable("Sections", (string)null);

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            InstructorId = 1,
                            SectionName = "S-MA1"
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            InstructorId = 2,
                            SectionName = "S-MA2"
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            InstructorId = 3,
                            SectionName = "S-MA3"
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 2,
                            InstructorId = 2,
                            SectionName = "S-MA4"
                        },
                        new
                        {
                            Id = 5,
                            CourseId = 3,
                            InstructorId = 3,
                            SectionName = "S-MA5"
                        },
                        new
                        {
                            Id = 6,
                            CourseId = 3,
                            InstructorId = 5,
                            SectionName = "S-MA6"
                        },
                        new
                        {
                            Id = 7,
                            CourseId = 4,
                            InstructorId = 4,
                            SectionName = "S-MA7"
                        },
                        new
                        {
                            Id = 8,
                            CourseId = 4,
                            InstructorId = 4,
                            SectionName = "S-MA8"
                        },
                        new
                        {
                            Id = 9,
                            CourseId = 5,
                            InstructorId = 2,
                            SectionName = "S-MA9"
                        },
                        new
                        {
                            Id = 10,
                            CourseId = 5,
                            InstructorId = 1,
                            SectionName = "S-MA10"
                        });
                });

            modelBuilder.Entity("MirationEF10.Entities.Instructor", b =>
                {
                    b.HasOne("MirationEF10.Entities.Office", "Office")
                        .WithOne("Instructor")
                        .HasForeignKey("MirationEF10.Entities.Instructor", "OfficeId");

                    b.Navigation("Office");
                });

            modelBuilder.Entity("MirationEF10.Entities.Section", b =>
                {
                    b.HasOne("MirationEF10.Entities.Course", "Course")
                        .WithMany("Sections")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MirationEF10.Entities.Instructor", "Instructor")
                        .WithMany("Sections")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("MirationEF10.Entities.Course", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("MirationEF10.Entities.Instructor", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("MirationEF10.Entities.Office", b =>
                {
                    b.Navigation("Instructor");
                });
#pragma warning restore 612, 618
        }
    }
}
