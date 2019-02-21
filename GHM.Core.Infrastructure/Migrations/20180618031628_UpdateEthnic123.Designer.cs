﻿// <auto-generated />
using System;
using GHM.Core.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GHM.Core.Infrastructure.Migrations
{
    [DbContext(typeof(CoreDbContext))]
    [Migration("20180618031628_UpdateEthnic123")]
    partial class UpdateEthnic123
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.0-rtm-30799")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GHM.Core.Domain.Models.ApiResource", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<bool>("Enabled");

                    b.HasKey("Name");

                    b.ToTable("ApiResource");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.Client", b =>
                {
                    b.Property<string>("ClientId")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(100);

                    b.Property<int>("AbsoluteRefreshTokenLifetime");

                    b.Property<int>("AccessTokenLifetime");

                    b.Property<int>("AccessTokenType");

                    b.Property<bool>("AllowAccessTokensViaBrowser");

                    b.Property<bool>("AllowOfflineAccess");

                    b.Property<bool>("AllowPlainTextPkce");

                    b.Property<bool>("AllowRememberConsent");

                    b.Property<bool>("AlwaysIncludeUserClaimsInIdToken");

                    b.Property<bool>("AlwaysSendClientClaims");

                    b.Property<int>("AuthorizationCodeLifetime");

                    b.Property<bool>("BackChannelLogoutSessionRequired");

                    b.Property<string>("BackChannelLogoutUri");

                    b.Property<string>("ClientAllowedGrantTypes");

                    b.Property<string>("ClientClaimsPrefix");

                    b.Property<string>("ClientName")
                        .IsRequired()
                        .HasMaxLength(450);

                    b.Property<string>("ClientUri");

                    b.Property<int?>("ConsentLifetime");

                    b.Property<DateTime>("CreateTime");

                    b.Property<bool>("EnableLocalLogin");

                    b.Property<bool>("Enabled");

                    b.Property<bool>("FrontChannelLogoutSessionRequired");

                    b.Property<string>("FrontChannelLogoutUri");

                    b.Property<int>("IdentityTokenLifetime");

                    b.Property<bool>("IncludeJwtId");

                    b.Property<bool>("IsDelete");

                    b.Property<string>("LogoUri");

                    b.Property<string>("PairWiseSubjectSalt");

                    b.Property<string>("ProtocolType");

                    b.Property<int>("RefreshTokenExpiration");

                    b.Property<int>("RefreshTokenUsage");

                    b.Property<bool>("RequireClientSecret");

                    b.Property<bool>("RequireConsent");

                    b.Property<bool>("RequirePkce");

                    b.Property<int>("SlidingRefreshTokenLifetime");

                    b.Property<string>("UnsignName")
                        .HasMaxLength(450)
                        .IsUnicode(false);

                    b.Property<bool>("UpdateAccessTokenClaimsOnRefresh");

                    b.HasKey("ClientId");

                    b.ToTable("Client");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.ClientAllowedCorsOrigin", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("ClientAllowedCorsOrigin");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.ClientAllowedScope", b =>
                {
                    b.Property<string>("ClientId")
                        .HasMaxLength(100);

                    b.Property<string>("Scope")
                        .HasMaxLength(500);

                    b.HasKey("ClientId", "Scope");

                    b.ToTable("ClientAllowedScope");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.ClientClaim", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.HasKey("Id");

                    b.ToTable("ClientClaim");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.ClientIdentityProviderRestriction", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("IdentityProviderRestriction")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("ClientIdentityProviderRestriction");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.ClientPostLogoutRedirectUris", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("ClientPostLogoutRedirectUris");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.ClientProperty", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Key")
                        .IsRequired();

                    b.Property<string>("Value")
                        .IsRequired();

                    b.HasKey("Id");

                    b.ToTable("ClientProperty");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.ClientRedirectUris", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Uri")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("ClientRedirectUris");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.ClientSecret", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClientId")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Description")
                        .HasMaxLength(4000);

                    b.Property<DateTime?>("Expiration");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(4000);

                    b.HasKey("Id");

                    b.ToTable("ClientSecret");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.District", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Culture")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<int>("ProvinceId");

                    b.Property<string>("ProvinceName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.HasKey("Id");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.Ethnic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("GroupId");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasMaxLength(150);

                    b.Property<string>("LanguageId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Ethnics");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.Language", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(10);

                    b.Property<string>("Description")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Languages");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.National", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Nationals");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.Page", b =>
                {
                    b.Property<int>("Id");

                    b.Property<string>("BgColor")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<int>("ChildCount")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(0);

                    b.Property<string>("Icon")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("IdPath")
                        .IsRequired()
                        .IsUnicode(false);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<int>("Order");

                    b.Property<string>("OrderPath");

                    b.Property<int?>("ParentId");

                    b.Property<string>("Url")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.PageTranslation", b =>
                {
                    b.Property<int>("PageId");

                    b.Property<string>("LanguageId")
                        .HasMaxLength(10)
                        .IsUnicode(false);

                    b.Property<string>("Description")
                        .IsUnicode(true);

                    b.Property<bool>("IsDelete")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(true);

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .IsUnicode(false);

                    b.HasKey("PageId", "LanguageId");

                    b.ToTable("PageTranslations");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.Province", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(250);

                    b.Property<int?>("NationalId");

                    b.HasKey("Id");

                    b.ToTable("Provinces");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.Religion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("LanguageId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("UnsignName");

                    b.HasKey("Id");

                    b.ToTable("Religions");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.RolesPages", b =>
                {
                    b.Property<string>("RoleId")
                        .HasMaxLength(50);

                    b.Property<int>("PageId");

                    b.Property<int>("Permissions");

                    b.HasKey("RoleId", "PageId");

                    b.ToTable("RolesPages");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.Tenant", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("ConcurrencyStamp")
                        .HasMaxLength(50);

                    b.Property<DateTime>("CreateTime")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<DateTime?>("LastUpdate");

                    b.Property<string>("Logo")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Note")
                        .HasMaxLength(500);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("UnsignName")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.ToTable("Tenant");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.TenantLanguage", b =>
                {
                    b.Property<string>("TenantId")
                        .HasMaxLength(50);

                    b.Property<string>("LanguageId")
                        .HasMaxLength(10);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDefault")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(false);

                    b.Property<bool>("IsDelete");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("TenantId", "LanguageId");

                    b.ToTable("TenantLanguages");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.TenantPage", b =>
                {
                    b.Property<string>("TenantId")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("PageId");

                    b.Property<bool>("IsDelete");

                    b.HasKey("TenantId", "PageId");

                    b.ToTable("TenantsPages");
                });

            modelBuilder.Entity("GHM.Core.Domain.Models.UserSetting", b =>
                {
                    b.Property<string>("UserId")
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Key")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("GroupKey")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(256);

                    b.HasKey("UserId", "Key");

                    b.ToTable("UserSettings");
                });

            modelBuilder.Entity("GHM.Infrastructure.Models.UserAccount", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("Avatar")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDelete");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("NormalizedUserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.Property<string>("PasswordHash");

                    b.Property<byte[]>("PasswordSalt")
                        .HasMaxLength(16);

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(20)
                        .IsUnicode(false);

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp")
                        .HasMaxLength(500)
                        .IsUnicode(false);

                    b.Property<string>("TenantId")
                        .IsRequired()
                        .HasMaxLength(50)
                        .IsUnicode(false);

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(256)
                        .IsUnicode(false);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("IdentityServer4.Models.IdentityResource", b =>
                {
                    b.Property<string>("Name")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description");

                    b.Property<string>("DisplayName");

                    b.Property<bool>("Emphasize");

                    b.Property<bool>("Enabled");

                    b.Property<bool>("Required");

                    b.Property<bool>("ShowInDiscoveryDocument");

                    b.HasKey("Name");

                    b.ToTable("IdentityResource");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("UserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("UserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("UsersRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("UserTokens");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("GHM.Core.Domain.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("GHM.Infrastructure.Models.UserAccount")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("GHM.Infrastructure.Models.UserAccount")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("GHM.Core.Domain.Models.Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("GHM.Infrastructure.Models.UserAccount")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("GHM.Infrastructure.Models.UserAccount")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
