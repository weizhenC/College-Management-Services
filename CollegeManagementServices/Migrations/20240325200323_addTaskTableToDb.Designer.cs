﻿// <auto-generated />
using CollegeManagementServices.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CollegeManagementServices.Migrations
{
    [DbContext(typeof(CollegeDbContext))]
    [Migration("20240325200323_addTaskTableToDb")]
    partial class addTaskTableToDb
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.0-preview.2.24128.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CollegeManagementServices.Models.StaffTask", b =>
                {
                    b.Property<int>("TaskId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TaskId"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Location")
                        .HasColumnType("int");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("TaskId");

                    b.ToTable("StaffTasks");

                    b.HasData(
                        new
                        {
                            TaskId = 1,
                            Code = "WG4",
                            Description = "Application Dev II",
                            Location = 0,
                            Status = 1
                        },
                        new
                        {
                            TaskId = 2,
                            Code = "SB3",
                            Description = "Cloud administration",
                            Location = 0,
                            Status = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
