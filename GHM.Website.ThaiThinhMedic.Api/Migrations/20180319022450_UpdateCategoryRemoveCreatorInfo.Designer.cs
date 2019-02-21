﻿// <auto-generated />
using GHM.Website.ThaiThinhMedic.Api.Infrastructure;
using GHM.Website.ThaiThinhMedic.Api.Infrastructure.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace GHM.Website.ThaiThinhMedic.Api.Migrations
{
    [DbContext(typeof(ThaiThinhMedicDbContext))]
    [Migration("20180319022450_UpdateCategoryRemoveCreatorInfo")]
    partial class UpdateCategoryRemoveCreatorInfo
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GHM.Website.ThaiThinhMedic.Api.Infrastructure.Models.Ads", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Ads");
                });

            modelBuilder.Entity("GHM.Website.ThaiThinhMedic.Api.Infrastructure.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("IdPath")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int?>("ParentId");

                    b.Property<string>("SeoLink")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("GHM.Website.ThaiThinhMedic.Api.Infrastructure.Models.Classes", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<DateTime?>("EndDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<DateTime?>("StartDate");

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Classes");
                });

            modelBuilder.Entity("GHM.Website.ThaiThinhMedic.Api.Infrastructure.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("SeoLink")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("GHM.Website.ThaiThinhMedic.Api.Infrastructure.Models.CourseRegister", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<int>("ClassId");

                    b.Property<int>("CourseId");

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Email")
                        .HasMaxLength(500);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Note")
                        .HasMaxLength(4000);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<int>("Status");

                    b.Property<string>("UserId");

                    b.HasKey("Id");

                    b.ToTable("CourseRegister");
                });

            modelBuilder.Entity("GHM.Website.ThaiThinhMedic.Api.Infrastructure.Models.Faq", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Answer")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("CreatorId")
                        .IsRequired();

                    b.Property<string>("CreatorName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Question")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Faq");
                });

            modelBuilder.Entity("GHM.Website.ThaiThinhMedic.Api.Infrastructure.Models.Feedback", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Content")
                        .IsRequired()
                        .HasMaxLength(2000);

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CustomerId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .HasMaxLength(500);

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20);

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("Feedback");
                });

            modelBuilder.Entity("GHM.Website.ThaiThinhMedic.Api.Infrastructure.Models.Menu", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("ChildCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<DateTime>("CreateTime");

                    b.Property<string>("Icon")
                        .HasMaxLength(20);

                    b.Property<string>("IdPath")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("NamePath")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<int>("Order");

                    b.Property<int?>("ParentId");

                    b.Property<int?>("ReferenceId");

                    b.Property<int>("ReferenceType");

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Url")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Menu");
                });

            modelBuilder.Entity("GHM.Website.ThaiThinhMedic.Api.Infrastructure.Models.News", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Attachments")
                        .HasMaxLength(500);

                    b.Property<int>("CommentCount");

                    b.Property<string>("Content")
                        .IsRequired();

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CreatorFullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("CreatorId")
                        .IsRequired();

                    b.Property<string>("CreatorImage")
                        .HasMaxLength(500);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Image")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("IsHomePage");

                    b.Property<bool>("IsHot");

                    b.Property<DateTime?>("LastUpdate");

                    b.Property<int>("LikeCount");

                    b.Property<int?>("Priority");

                    b.Property<string>("Source")
                        .HasMaxLength(500);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int>("ViewCount");

                    b.HasKey("Id");

                    b.ToTable("News");
                });

            modelBuilder.Entity("GHM.Website.ThaiThinhMedic.Api.Infrastructure.Models.NewsCategory", b =>
                {
                    b.Property<int>("NewsId");

                    b.Property<int>("CategoryId");

                    b.Property<bool>("CategoryIsActive");

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<string>("CategorySeoLink")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<DateTime>("CreateTime");

                    b.Property<int>("Id");

                    b.Property<string>("NewsSeoLink")
                        .IsRequired()
                        .HasMaxLength(1000);

                    b.HasKey("NewsId", "CategoryId");

                    b.ToTable("NewsCategory");
                });
#pragma warning restore 612, 618
        }
    }
}
