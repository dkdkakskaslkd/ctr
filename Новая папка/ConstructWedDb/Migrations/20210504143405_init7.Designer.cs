﻿// <auto-generated />
using System;
using ConstructWedDb.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConstructWedDb.Migrations
{
    [DbContext(typeof(ConstructWedDbContext))]
    [Migration("20210504143405_init7")]
    partial class init7
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.5")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ConstructWedDb.Models.Brigade", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long?>("Staff1ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("Staff2ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("Staff3ID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("Staff1ID");

                    b.HasIndex("Staff2ID");

                    b.HasIndex("Staff3ID");

                    b.ToTable("Brigade");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Customer", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Material", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Packaging")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Material");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Order", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("AboutPayment")
                        .HasColumnType("bit");

                    b.Property<long?>("BrigadeID")
                        .HasColumnType("bigint");

                    b.Property<bool>("CompletionMark")
                        .HasColumnType("bit");

                    b.Property<long?>("CustomerID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("EndDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Price")
                        .HasColumnType("int");

                    b.Property<long?>("StaffID")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("TypeOfJobID")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("BrigadeID");

                    b.HasIndex("CustomerID");

                    b.HasIndex("StaffID");

                    b.HasIndex("TypeOfJobID");

                    b.ToTable("Order");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Position", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Requirements")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Responsibilities")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Salary")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Staff", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("FullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportData")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("PositionID")
                        .HasColumnType("bigint");

                    b.Property<string>("Sex")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("PositionID");

                    b.ToTable("Staff");
                });

            modelBuilder.Entity("ConstructWedDb.Models.TypeOfJob", b =>
                {
                    b.Property<long>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("Material1ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("Material2ID")
                        .HasColumnType("bigint");

                    b.Property<long?>("Material3ID")
                        .HasColumnType("bigint");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Price")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.HasIndex("Material1ID");

                    b.HasIndex("Material2ID");

                    b.HasIndex("Material3ID");

                    b.ToTable("TypeOfJob");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Brigade", b =>
                {
                    b.HasOne("ConstructWedDb.Models.Staff", "Staff1")
                        .WithMany()
                        .HasForeignKey("Staff1ID");

                    b.HasOne("ConstructWedDb.Models.Staff", "Staff2")
                        .WithMany()
                        .HasForeignKey("Staff2ID");

                    b.HasOne("ConstructWedDb.Models.Staff", "Staff3")
                        .WithMany()
                        .HasForeignKey("Staff3ID");

                    b.Navigation("Staff1");

                    b.Navigation("Staff2");

                    b.Navigation("Staff3");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Order", b =>
                {
                    b.HasOne("ConstructWedDb.Models.Brigade", "Brigade")
                        .WithMany("Order")
                        .HasForeignKey("BrigadeID");

                    b.HasOne("ConstructWedDb.Models.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerID");

                    b.HasOne("ConstructWedDb.Models.Staff", "Staff")
                        .WithMany("Order")
                        .HasForeignKey("StaffID");

                    b.HasOne("ConstructWedDb.Models.TypeOfJob", "TypeOfJob")
                        .WithMany("Order")
                        .HasForeignKey("TypeOfJobID");

                    b.Navigation("Brigade");

                    b.Navigation("Customer");

                    b.Navigation("Staff");

                    b.Navigation("TypeOfJob");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Staff", b =>
                {
                    b.HasOne("ConstructWedDb.Models.Position", "Position")
                        .WithMany("Staff")
                        .HasForeignKey("PositionID");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("ConstructWedDb.Models.TypeOfJob", b =>
                {
                    b.HasOne("ConstructWedDb.Models.Material", "Material1")
                        .WithMany()
                        .HasForeignKey("Material1ID");

                    b.HasOne("ConstructWedDb.Models.Material", "Material2")
                        .WithMany()
                        .HasForeignKey("Material2ID");

                    b.HasOne("ConstructWedDb.Models.Material", "Material3")
                        .WithMany()
                        .HasForeignKey("Material3ID");

                    b.Navigation("Material1");

                    b.Navigation("Material2");

                    b.Navigation("Material3");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Brigade", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Customer", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Position", b =>
                {
                    b.Navigation("Staff");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Staff", b =>
                {
                    b.Navigation("Order");
                });

            modelBuilder.Entity("ConstructWedDb.Models.TypeOfJob", b =>
                {
                    b.Navigation("Order");
                });
#pragma warning restore 612, 618
        }
    }
}
