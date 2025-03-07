﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DClassTask.Migrations
{
    [DbContext(typeof(AddDBContext))]
    [Migration("20250303114653_fixeddataas")]
    partial class fixeddataas
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("location")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            location = "Riyadh"
                        },
                        new
                        {
                            Id = 2,
                            location = "Jeddah"
                        },
                        new
                        {
                            Id = 3,
                            location = "Dammam"
                        });
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.Property<int>("employeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("employeeId"));

                    b.Property<int>("deptId")
                        .HasColumnType("int");

                    b.Property<string>("employeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("salary")
                        .HasColumnType("float");

                    b.HasKey("employeeId");

                    b.HasIndex("deptId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            employeeId = 1,
                            deptId = 1,
                            employeeName = "Ahmed Al-Qahtani",
                            salary = 12000.0
                        },
                        new
                        {
                            employeeId = 2,
                            deptId = 2,
                            employeeName = "Khalid Al-Mutairi",
                            salary = 15000.0
                        },
                        new
                        {
                            employeeId = 3,
                            deptId = 3,
                            employeeName = "Faisal Al-Dosari",
                            salary = 10000.0
                        },
                        new
                        {
                            employeeId = 4,
                            deptId = 1,
                            employeeName = "Mansour Al-Harbi",
                            salary = 14000.0
                        },
                        new
                        {
                            employeeId = 5,
                            deptId = 2,
                            employeeName = "Saud Al-Otaibi",
                            salary = 13000.0
                        });
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<int>("ProjectId")
                        .HasColumnType("int");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.HasKey("EmployeeId", "ProjectId");

                    b.HasIndex("ProjectId");

                    b.ToTable("EmployeeProjects");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            ProjectId = 1,
                            StartDate = new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 1,
                            ProjectId = 2,
                            StartDate = new DateTime(2024, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 1,
                            ProjectId = 3,
                            StartDate = new DateTime(2024, 1, 10, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 2,
                            ProjectId = 1,
                            StartDate = new DateTime(2024, 4, 20, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        },
                        new
                        {
                            EmployeeId = 2,
                            ProjectId = 4,
                            StartDate = new DateTime(2024, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified)
                        });
                });

            modelBuilder.Entity("Project", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Projects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            EndDate = new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Vision 2030 project"
                        },
                        new
                        {
                            Id = 2,
                            EndDate = new DateTime(2024, 7, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2024, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "E-Commerce"
                        },
                        new
                        {
                            Id = 3,
                            EndDate = new DateTime(2024, 8, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2024, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Cloud computing"
                        },
                        new
                        {
                            Id = 4,
                            EndDate = new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Cybersecurity"
                        },
                        new
                        {
                            Id = 5,
                            EndDate = new DateTime(2024, 7, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            StartDate = new DateTime(2024, 4, 18, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Title = "Digital Banking"
                        });
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.HasOne("Department", "dept")
                        .WithMany("employees")
                        .HasForeignKey("deptId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("dept");
                });

            modelBuilder.Entity("EmployeeProject", b =>
                {
                    b.HasOne("Employee", "Employee")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Project", "Project")
                        .WithMany("EmployeeProjects")
                        .HasForeignKey("ProjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Project");
                });

            modelBuilder.Entity("Department", b =>
                {
                    b.Navigation("employees");
                });

            modelBuilder.Entity("Employee", b =>
                {
                    b.Navigation("EmployeeProjects");
                });

            modelBuilder.Entity("Project", b =>
                {
                    b.Navigation("EmployeeProjects");
                });
#pragma warning restore 612, 618
        }
    }
}
