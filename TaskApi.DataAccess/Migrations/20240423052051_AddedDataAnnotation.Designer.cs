﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using TaskApi.DataAccess;

#nullable disable

namespace TaskAPI.DataAccess.Migrations
{
    [DbContext(typeof(TodoDbContext))]
    [Migration("20240423052051_AddedDataAnnotation")]
    partial class AddedDataAnnotation
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressNo")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.HasKey("Id");

                    b.ToTable("Authors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AddressNo = "45",
                            City = "Colomboo 1",
                            FullName = "Mgs dilshan",
                            Street = "Street 1"
                        },
                        new
                        {
                            Id = 2,
                            AddressNo = "123",
                            City = "Cityville",
                            FullName = "Sunil Bandara",
                            Street = "Main Street"
                        },
                        new
                        {
                            Id = 3,
                            AddressNo = "456",
                            City = "Townsville",
                            FullName = "Chaminda Bandara",
                            Street = "Oak Avenue"
                        },
                        new
                        {
                            Id = 4,
                            AddressNo = "789",
                            City = "Villageville",
                            FullName = "Hansi Gamage",
                            Street = "Pine Street"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AuthorId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Created")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(300)
                        .HasColumnType("nvarchar(300)");

                    b.Property<DateTime>("Due")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.HasKey("Id");

                    b.HasIndex("AuthorId");

                    b.ToTable("Todos");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            AuthorId = 1,
                            Created = new DateTime(2024, 4, 23, 10, 50, 50, 146, DateTimeKind.Local).AddTicks(8883),
                            Description = "Get some text books for school",
                            Due = new DateTime(2024, 4, 28, 10, 50, 50, 146, DateTimeKind.Local).AddTicks(8967),
                            Status = 0,
                            Title = "Get books for school - DB"
                        },
                        new
                        {
                            Id = 2,
                            AuthorId = 1,
                            Created = new DateTime(2024, 4, 23, 10, 50, 50, 146, DateTimeKind.Local).AddTicks(8996),
                            Description = "Go to supermarket and buy some stuff",
                            Due = new DateTime(2024, 4, 28, 10, 50, 50, 146, DateTimeKind.Local).AddTicks(8997),
                            Status = 0,
                            Title = "Need some grocceries"
                        },
                        new
                        {
                            Id = 3,
                            AuthorId = 2,
                            Created = new DateTime(2024, 4, 23, 10, 50, 50, 146, DateTimeKind.Local).AddTicks(9043),
                            Description = "Buy new camera",
                            Due = new DateTime(2024, 4, 28, 10, 50, 50, 146, DateTimeKind.Local).AddTicks(9044),
                            Status = 0,
                            Title = "Purchase camera"
                        });
                });

            modelBuilder.Entity("TaskAPI.Models.Todo", b =>
                {
                    b.HasOne("TaskAPI.Models.Author", "Author")
                        .WithMany("Todos")
                        .HasForeignKey("AuthorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Author");
                });

            modelBuilder.Entity("TaskAPI.Models.Author", b =>
                {
                    b.Navigation("Todos");
                });
#pragma warning restore 612, 618
        }
    }
}