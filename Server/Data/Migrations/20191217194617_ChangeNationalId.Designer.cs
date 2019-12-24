﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    [Migration("20191217194617_ChangeNationalId")]
    partial class ChangeNationalId
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Driver", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DefensiveDriving")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DriverName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DrugTestDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("HiringDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("LicenseExpiryDate")
                        .HasColumnType("date");

                    b.Property<int>("LicenseType")
                        .HasColumnType("int");

                    b.Property<DateTime?>("MedicalExaminationDate")
                        .HasColumnType("date");

                    b.Property<string>("NationalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubContractor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TerminationDate")
                        .HasColumnType("date");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.Property<string>("WarningLetter1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WarningLetter2")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("Drivers");
                });

            modelBuilder.Entity("Domain.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Domain.Entities.Vehicle", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Brand")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Characters")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Comment")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ExpiryDate")
                        .HasColumnType("date");

                    b.Property<string>("GPSLink")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("LastSeenDate")
                        .HasColumnType("date");

                    b.Property<DateTime?>("LatestMaintenanceDate")
                        .HasColumnType("date");

                    b.Property<int?>("MaintenanceKM")
                        .HasColumnType("int");

                    b.Property<string>("Model")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("NextTyreChangeKM")
                        .HasColumnType("int");

                    b.Property<string>("Numbers")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PlateNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SubContractor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Type")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("TyreChangeDate")
                        .HasColumnType("date");

                    b.Property<int?>("TyreChangeKM")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("VendorId")
                        .HasColumnType("int");

                    b.Property<string>("Year")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("VendorId");

                    b.ToTable("Vehicles");
                });

            modelBuilder.Entity("Domain.Entities.Vendor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vendors");
                });

            modelBuilder.Entity("Domain.Entities.Driver", b =>
                {
                    b.HasOne("Domain.Entities.Vendor", "Vendor")
                        .WithMany("Drivers")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Vehicle", b =>
                {
                    b.HasOne("Domain.Entities.Vendor", "Vendor")
                        .WithMany("Vehicles")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
