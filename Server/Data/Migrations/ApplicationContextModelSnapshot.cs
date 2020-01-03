﻿// <auto-generated />
using System;
using Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Data.Migrations
{
    [DbContext(typeof(ApplicationContext))]
    partial class ApplicationContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Entities.Frequency", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Frequencys");
                });

            modelBuilder.Entity("Domain.Entities.Instruction", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Instructions");
                });

            modelBuilder.Entity("Domain.Entities.Knowing", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Knowings");
                });

            modelBuilder.Entity("Domain.Entities.Medicine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("FrequencyId")
                        .HasColumnType("int");

                    b.Property<int>("MedicineTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("FrequencyId");

                    b.HasIndex("MedicineTypeId");

                    b.ToTable("Medicines");
                });

            modelBuilder.Entity("Domain.Entities.MedicineType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("MedicineTypes");
                });

            modelBuilder.Entity("Domain.Entities.Occupation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Occupations");
                });

            modelBuilder.Entity("Domain.Entities.Patient", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BMI")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Birthday")
                        .HasColumnType("date");

                    b.Property<string>("BloodGroup")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Children")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Code")
                        .HasColumnType("int");

                    b.Property<DateTime?>("HusbandBirthday")
                        .HasColumnType("date");

                    b.Property<string>("HusbandName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("HusbandOccupationId")
                        .HasColumnType("int");

                    b.Property<string>("HusbandPhone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KnowingId")
                        .HasColumnType("int");

                    b.Property<int>("MaritalStatus")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OccupationId")
                        .HasColumnType("int");

                    b.Property<string>("Phone1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Residence")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Smoking")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Weight")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("HusbandOccupationId");

                    b.HasIndex("KnowingId");

                    b.HasIndex("OccupationId");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("Domain.Entities.Prescription", b =>
                {
                    b.Property<int>("PrescriptionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Diagonsis")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PatientId")
                        .HasColumnType("int");

                    b.HasKey("PrescriptionId");

                    b.HasIndex("PatientId");

                    b.ToTable("Prescriptions");
                });

            modelBuilder.Entity("Domain.Entities.PrescriptionInstruction", b =>
                {
                    b.Property<int>("PrescriptionInstructionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InstructionId")
                        .HasColumnType("int");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.HasKey("PrescriptionInstructionId");

                    b.HasIndex("InstructionId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("PrescriptionInstructions");
                });

            modelBuilder.Entity("Domain.Entities.PrescriptionMedicine", b =>
                {
                    b.Property<int>("PrescriptionMedicineId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<int>("Frequency")
                        .HasColumnType("int");

                    b.Property<int>("MedicineId")
                        .HasColumnType("int");

                    b.Property<string>("Notes_AR")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Notes_Eng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PrescriptionId")
                        .HasColumnType("int");

                    b.HasKey("PrescriptionMedicineId");

                    b.HasIndex("MedicineId");

                    b.HasIndex("PrescriptionId");

                    b.ToTable("PrescriptionMedicines");
                });

            modelBuilder.Entity("Domain.Entities.Medicine", b =>
                {
                    b.HasOne("Domain.Entities.Frequency", "Frequency")
                        .WithMany("Medicines")
                        .HasForeignKey("FrequencyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.MedicineType", "MedicineType")
                        .WithMany("Medicines")
                        .HasForeignKey("MedicineTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.Patient", b =>
                {
                    b.HasOne("Domain.Entities.Occupation", "HusbandOccupation")
                        .WithMany("HusbandsPatients")
                        .HasForeignKey("HusbandOccupationId");

                    b.HasOne("Domain.Entities.Knowing", "Knowing")
                        .WithMany("Patients")
                        .HasForeignKey("KnowingId");

                    b.HasOne("Domain.Entities.Occupation", "Occupation")
                        .WithMany("Patients")
                        .HasForeignKey("OccupationId");
                });

            modelBuilder.Entity("Domain.Entities.Prescription", b =>
                {
                    b.HasOne("Domain.Entities.Patient", "Patient")
                        .WithMany()
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.PrescriptionInstruction", b =>
                {
                    b.HasOne("Domain.Entities.Instruction", "Instruction")
                        .WithMany()
                        .HasForeignKey("InstructionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Prescription", "Prescription")
                        .WithMany("Instructions")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Domain.Entities.PrescriptionMedicine", b =>
                {
                    b.HasOne("Domain.Entities.Medicine", "Medicine")
                        .WithMany()
                        .HasForeignKey("MedicineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Domain.Entities.Prescription", "Prescription")
                        .WithMany("Medicines")
                        .HasForeignKey("PrescriptionId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
