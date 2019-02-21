﻿// <auto-generated />
using System;
using GHM.Customer.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GHM.Customer.Infrastructure.Migrations
{
    [DbContext(typeof(CustomerDbContext))]
    [Migration("20180621090546_InitialCreate24")]
    partial class InitialCreate24
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GHM.Customer.Domain.Models.ContactPatient", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<DateTime?>("LastUpdate");

                    b.Property<string>("PatientId");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.HasKey("Id");

                    b.ToTable("ContactPatients");
                });

            modelBuilder.Entity("GHM.Customer.Domain.Models.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ChildCount");

                    b.Property<string>("ConcurrencyStamp")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("IdPath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime?>("LastUpdate");

                    b.Property<int>("Level");

                    b.Property<int>("Order");

                    b.Property<string>("OrderPath")
                        .IsRequired()
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<int?>("ParentId");

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("GHM.Customer.Domain.Models.JobTranslation", b =>
                {
                    b.Property<int>("JobId");

                    b.Property<string>("LanguageId")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("ParentName")
                        .HasMaxLength(256);

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("JobId", "LanguageId");

                    b.ToTable("JobTranslations");
                });

            modelBuilder.Entity("GHM.Customer.Domain.Models.Patient", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("AddressContact")
                        .HasMaxLength(500)
                        .IsUnicode(true);

                    b.Property<DateTime?>("Birthday")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<string>("ConcurrencyStamp")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int?>("DistrictId");

                    b.Property<string>("DistrictName")
                        .HasMaxLength(150)
                        .IsUnicode(true);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<int?>("EthnicsId");

                    b.Property<string>("EthnicsName")
                        .HasMaxLength(150)
                        .IsUnicode(true);

                    b.Property<int?>("Gender");

                    b.Property<string>("IdCardNumber")
                        .HasMaxLength(30)
                        .IsUnicode(true);

                    b.Property<int?>("JobId");

                    b.Property<DateTime?>("LastUpdate");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<int?>("NationalId");

                    b.Property<string>("NationalName")
                        .HasMaxLength(150)
                        .IsUnicode(true);

                    b.Property<string>("PatientCode")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<string>("PatientResourceId")
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<int?>("ProvinceId");

                    b.Property<string>("ProvinceName")
                        .HasMaxLength(150)
                        .IsUnicode(true);

                    b.Property<int?>("ReligionId");

                    b.Property<string>("ReligionName")
                        .HasMaxLength(150)
                        .IsUnicode(true);

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("GHM.Customer.Domain.Models.PatientContact", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .HasMaxLength(50);

                    b.Property<int>("ContactType");

                    b.Property<string>("ContactValue")
                        .IsRequired()
                        .HasMaxLength(100)
                        .IsUnicode(true);

                    b.Property<DateTime>("CreateTime");

                    b.Property<DateTime?>("LastUpdate");

                    b.Property<string>("PatientId");

                    b.HasKey("Id");

                    b.ToTable("PatientContacts");
                });

            modelBuilder.Entity("GHM.Customer.Domain.Models.PatientResource", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("ConcurrencyStamp")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime?>("LastUpdate");

                    b.Property<int>("Order");

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("PatientResources");
                });

            modelBuilder.Entity("GHM.Customer.Domain.Models.PatientResourceTranslation", b =>
                {
                    b.Property<string>("PatientResourceId")
                        .HasMaxLength(50);

                    b.Property<string>("LanguageId")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.HasKey("PatientResourceId", "LanguageId");

                    b.ToTable("PatientResourceTranslations");
                });

            modelBuilder.Entity("GHM.Customer.Domain.Models.PatientSubject", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime?>("LastUpdate");

                    b.Property<int>("Order");

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<float?>("TotalReduction");

                    b.HasKey("Id");

                    b.ToTable("PatientSubjects");
                });

            modelBuilder.Entity("GHM.Customer.Domain.Models.PatientSubjectTranslation", b =>
                {
                    b.Property<string>("PatientSubjectId");

                    b.Property<string>("LanguageId")
                        .HasMaxLength(30)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .HasMaxLength(4000)
                        .IsUnicode(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.HasKey("PatientSubjectId", "LanguageId");

                    b.ToTable("PatientSubjectTranslations");
                });

            modelBuilder.Entity("GHM.Customer.Domain.Models.test", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<string>("ConcurrencyStamp")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<DateTime?>("LastUpdate");

                    b.HasKey("Id");

                    b.ToTable("tests");
                });

            modelBuilder.Entity("GHM.Customer.Domain.Models.testTranslation", b =>
                {
                    b.Property<string>("TestId")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<string>("LanguageId")
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(true);

                    b.HasKey("TestId", "LanguageId");

                    b.ToTable("testTranslations");
                });
#pragma warning restore 612, 618
        }
    }
}
