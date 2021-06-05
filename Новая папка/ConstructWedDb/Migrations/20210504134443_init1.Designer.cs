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
    [Migration("20210504134443_init1")]
    partial class init1
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

                    b.Property<long?>("TypeOfJobID")
                        .HasColumnType("bigint");

                    b.Property<long?>("TypeOfJobID1")
                        .HasColumnType("bigint");

                    b.Property<long?>("TypeOfJobID2")
                        .HasColumnType("bigint");

                    b.HasKey("ID");

                    b.HasIndex("TypeOfJobID");

                    b.HasIndex("TypeOfJobID1");

                    b.HasIndex("TypeOfJobID2");

                    b.ToTable("Material");
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

                    b.Property<long?>("BrigadeID")
                        .HasColumnType("bigint");

                    b.Property<long?>("BrigadeID1")
                        .HasColumnType("bigint");

                    b.Property<long?>("BrigadeID2")
                        .HasColumnType("bigint");

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

                    b.HasIndex("BrigadeID");

                    b.HasIndex("BrigadeID1");

                    b.HasIndex("BrigadeID2");

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

                    b.ToTable("TypeOfJob");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Material", b =>
                {
                    b.HasOne("ConstructWedDb.Models.TypeOfJob", null)
                        .WithMany("Material1")
                        .HasForeignKey("TypeOfJobID");

                    b.HasOne("ConstructWedDb.Models.TypeOfJob", null)
                        .WithMany("Material2")
                        .HasForeignKey("TypeOfJobID1");

                    b.HasOne("ConstructWedDb.Models.TypeOfJob", null)
                        .WithMany("Material3")
                        .HasForeignKey("TypeOfJobID2");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Staff", b =>
                {
                    b.HasOne("ConstructWedDb.Models.Brigade", null)
                        .WithMany("Staff1")
                        .HasForeignKey("BrigadeID");

                    b.HasOne("ConstructWedDb.Models.Brigade", null)
                        .WithMany("Staff2")
                        .HasForeignKey("BrigadeID1");

                    b.HasOne("ConstructWedDb.Models.Brigade", null)
                        .WithMany("Staff3")
                        .HasForeignKey("BrigadeID2");

                    b.HasOne("ConstructWedDb.Models.Position", "Position")
                        .WithMany("Staff")
                        .HasForeignKey("PositionID");

                    b.Navigation("Position");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Brigade", b =>
                {
                    b.Navigation("Staff1");

                    b.Navigation("Staff2");

                    b.Navigation("Staff3");
                });

            modelBuilder.Entity("ConstructWedDb.Models.Position", b =>
                {
                    b.Navigation("Staff");
                });

            modelBuilder.Entity("ConstructWedDb.Models.TypeOfJob", b =>
                {
                    b.Navigation("Material1");

                    b.Navigation("Material2");

                    b.Navigation("Material3");
                });
#pragma warning restore 612, 618
        }
    }
}
