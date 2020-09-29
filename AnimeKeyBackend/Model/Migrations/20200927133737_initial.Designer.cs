﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Model;

namespace Model.Migrations
{
    [DbContext(typeof(DBContext))]
    [Migration("20200927133737_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Model.AgeGroup", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<string>("CountryArabicName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("CountryEnglishName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<int>("EndAge");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.Property<int>("StartAge");

                    b.HasKey("Id");

                    b.ToTable("AgeGroup");
                });

            modelBuilder.Entity("Model.Category", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.HasKey("Id");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("Model.City", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<long>("CountryID");

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("EnglishName")
                        .HasMaxLength(500);

                    b.Property<string>("IndonesiahName")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.HasKey("Id");

                    b.ToTable("City");
                });

            modelBuilder.Entity("Model.Country", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("EnglishName")
                        .HasMaxLength(500);

                    b.Property<string>("IndonesiahName")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("Model.District", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<long>("CityID");

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("EnglishName")
                        .HasMaxLength(500);

                    b.Property<string>("IndonesiahName")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.HasKey("Id");

                    b.HasIndex("CityID");

                    b.ToTable("District");
                });

            modelBuilder.Entity("Model.GroupPermissions", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("GroupId");

                    b.Property<long>("PermissionId");

                    b.Property<long>("ScreenId");

                    b.HasKey("Id");

                    b.ToTable("GroupPermissions");
                });

            modelBuilder.Entity("Model.Groups", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("EnglishName")
                        .HasMaxLength(500);

                    b.Property<string>("IndonesiahName")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsMaster");

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.HasKey("Id");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ArabicName = "مجموعة عامة",
                            Code = "GR-1",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 508, DateTimeKind.Local).AddTicks(1283),
                            EnglishName = "General Group",
                            IsActive = true,
                            IsDeleted = false,
                            IsMaster = true
                        });
                });

            modelBuilder.Entity("Model.LookUpItems", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .IsRequired();

                    b.Property<long?>("CompanyId");

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("EnglishName");

                    b.Property<string>("IndonesiahName")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<long>("LookUpId");

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.HasKey("Id");

                    b.ToTable("LookUpItems");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ArabicName = "ذكر",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(595),
                            EnglishName = "Male",
                            IsActive = true,
                            IsDeleted = false,
                            LookUpId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            ArabicName = "انثي",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(1108),
                            EnglishName = "Female",
                            IsActive = true,
                            IsDeleted = false,
                            LookUpId = 1L
                        });
                });

            modelBuilder.Entity("Model.LookUps", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .IsRequired();

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("EnglishName");

                    b.Property<string>("IndonesiahName")
                        .HasMaxLength(500);

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.HasKey("Id");

                    b.ToTable("LookUps");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ArabicName = "الجنس",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 508, DateTimeKind.Local).AddTicks(8474),
                            EnglishName = "Gender",
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Model.Modules", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Icon")
                        .IsRequired();

                    b.Property<string>("IndonesiahName")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.HasKey("Id");

                    b.ToTable("Modules");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ArabicName = "ادارة المستخدمين",
                            Code = "MOD-1",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(2374),
                            EnglishName = "Users Management",
                            Icon = "fas fa-users-cog",
                            IndonesiahName = "Manajemen Pengguna",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 2L,
                            ArabicName = "اعدادات النظام",
                            Code = "MOD-2",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(2828),
                            EnglishName = "System Settings",
                            Icon = "fa fa-cogs",
                            IndonesiahName = "Pengaturan sistem",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 6L,
                            ArabicName = "الاعدادات",
                            Code = "MOD-6",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(2848),
                            EnglishName = "Configuration",
                            Icon = "fa fa-cogs",
                            IndonesiahName = "Konfigurasi",
                            IsActive = true,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Model.Permissions", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("IndonesiahName")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.Property<string>("PermissionCode")
                        .HasMaxLength(500);

                    b.HasKey("Id");

                    b.ToTable("Permissions");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ArabicName = "عرض",
                            Code = "PER-1",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(4021),
                            EnglishName = "View",
                            IsActive = true,
                            IsDeleted = false,
                            PermissionCode = "Index"
                        },
                        new
                        {
                            Id = 2L,
                            ArabicName = "أنشاء",
                            Code = "PER-2",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(4240),
                            EnglishName = "Create",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 3L,
                            ArabicName = "تعديل",
                            Code = "PER-3",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(4260),
                            EnglishName = "Edit",
                            IsActive = true,
                            IsDeleted = false
                        },
                        new
                        {
                            Id = 4L,
                            ArabicName = "حذف",
                            Code = "PER-4",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(4274),
                            EnglishName = "Delete",
                            IsActive = true,
                            IsDeleted = false
                        });
                });

            modelBuilder.Entity("Model.ScreenPermissions", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("PermissionId");

                    b.Property<long>("ScreenId");

                    b.HasKey("Id");

                    b.ToTable("ScreenPermissions");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            PermissionId = 1L,
                            ScreenId = 1L
                        },
                        new
                        {
                            Id = 2L,
                            PermissionId = 2L,
                            ScreenId = 1L
                        },
                        new
                        {
                            Id = 3L,
                            PermissionId = 3L,
                            ScreenId = 1L
                        },
                        new
                        {
                            Id = 4L,
                            PermissionId = 4L,
                            ScreenId = 1L
                        },
                        new
                        {
                            Id = 5L,
                            PermissionId = 1L,
                            ScreenId = 2L
                        },
                        new
                        {
                            Id = 6L,
                            PermissionId = 2L,
                            ScreenId = 2L
                        },
                        new
                        {
                            Id = 7L,
                            PermissionId = 3L,
                            ScreenId = 2L
                        },
                        new
                        {
                            Id = 8L,
                            PermissionId = 4L,
                            ScreenId = 2L
                        },
                        new
                        {
                            Id = 9L,
                            PermissionId = 1L,
                            ScreenId = 3L
                        },
                        new
                        {
                            Id = 10L,
                            PermissionId = 2L,
                            ScreenId = 3L
                        },
                        new
                        {
                            Id = 11L,
                            PermissionId = 3L,
                            ScreenId = 3L
                        },
                        new
                        {
                            Id = 12L,
                            PermissionId = 4L,
                            ScreenId = 3L
                        },
                        new
                        {
                            Id = 13L,
                            PermissionId = 1L,
                            ScreenId = 4L
                        },
                        new
                        {
                            Id = 14L,
                            PermissionId = 2L,
                            ScreenId = 4L
                        },
                        new
                        {
                            Id = 15L,
                            PermissionId = 3L,
                            ScreenId = 4L
                        },
                        new
                        {
                            Id = 16L,
                            PermissionId = 4L,
                            ScreenId = 4L
                        },
                        new
                        {
                            Id = 21L,
                            PermissionId = 1L,
                            ScreenId = 6L
                        },
                        new
                        {
                            Id = 22L,
                            PermissionId = 2L,
                            ScreenId = 6L
                        },
                        new
                        {
                            Id = 23L,
                            PermissionId = 3L,
                            ScreenId = 6L
                        },
                        new
                        {
                            Id = 24L,
                            PermissionId = 4L,
                            ScreenId = 6L
                        },
                        new
                        {
                            Id = 33L,
                            PermissionId = 1L,
                            ScreenId = 7L
                        },
                        new
                        {
                            Id = 34L,
                            PermissionId = 2L,
                            ScreenId = 7L
                        },
                        new
                        {
                            Id = 35L,
                            PermissionId = 3L,
                            ScreenId = 7L
                        },
                        new
                        {
                            Id = 36L,
                            PermissionId = 4L,
                            ScreenId = 7L
                        },
                        new
                        {
                            Id = 37L,
                            PermissionId = 1L,
                            ScreenId = 8L
                        },
                        new
                        {
                            Id = 38L,
                            PermissionId = 2L,
                            ScreenId = 8L
                        },
                        new
                        {
                            Id = 39L,
                            PermissionId = 3L,
                            ScreenId = 8L
                        },
                        new
                        {
                            Id = 40L,
                            PermissionId = 4L,
                            ScreenId = 8L
                        },
                        new
                        {
                            Id = 41L,
                            PermissionId = 1L,
                            ScreenId = 9L
                        },
                        new
                        {
                            Id = 42L,
                            PermissionId = 2L,
                            ScreenId = 9L
                        },
                        new
                        {
                            Id = 43L,
                            PermissionId = 3L,
                            ScreenId = 9L
                        },
                        new
                        {
                            Id = 44L,
                            PermissionId = 4L,
                            ScreenId = 9L
                        });
                });

            modelBuilder.Entity("Model.Screens", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ArabicName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("EnglishName")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("Icon")
                        .IsRequired();

                    b.Property<string>("IndonesiahName")
                        .HasMaxLength(500);

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.Property<long>("ModuleId");

                    b.Property<string>("ScreenCode")
                        .IsRequired()
                        .HasMaxLength(500);

                    b.Property<string>("URL");

                    b.HasKey("Id");

                    b.ToTable("Screens");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            ArabicName = "المجموعات",
                            Code = "UGR-1",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(5823),
                            EnglishName = "Groups",
                            Icon = "fas fa-users",
                            IndonesiahName = "Grup",
                            IsActive = true,
                            IsDeleted = false,
                            ModuleId = 1L,
                            ScreenCode = "Groups"
                        },
                        new
                        {
                            Id = 2L,
                            ArabicName = "المستخدمين",
                            Code = "UUS-2",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6282),
                            EnglishName = "Users",
                            Icon = "fas fa-users-cog",
                            IndonesiahName = "Pengguna",
                            IsActive = true,
                            IsDeleted = false,
                            ModuleId = 1L,
                            ScreenCode = "Users"
                        },
                        new
                        {
                            Id = 3L,
                            ArabicName = "المعلومات الثابتة",
                            Code = "SSL-3",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6305),
                            EnglishName = "LookUps",
                            Icon = "fas fa-indent",
                            IndonesiahName = "Lihatlah",
                            IsActive = true,
                            IsDeleted = false,
                            ModuleId = 2L,
                            ScreenCode = "LookUps"
                        },
                        new
                        {
                            Id = 4L,
                            ArabicName = "الدول والمدن والمناطق",
                            Code = "CCD-4",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6319),
                            EnglishName = "Countries , Cities & Districts",
                            Icon = "fas fa-globe-europe",
                            IndonesiahName = "Negara, Kota, dan Distrik",
                            IsActive = true,
                            IsDeleted = false,
                            ModuleId = 2L,
                            ScreenCode = "Country"
                        },
                        new
                        {
                            Id = 5L,
                            ArabicName = "افرع الشركة",
                            Code = "SC-5",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6332),
                            EnglishName = "Company Branches",
                            Icon = "fas fa-code-branch",
                            IndonesiahName = "Cabang Perusahaan",
                            IsActive = true,
                            IsDeleted = false,
                            ModuleId = 1L,
                            ScreenCode = "CompanyBranches"
                        },
                        new
                        {
                            Id = 6L,
                            ArabicName = "ترتيب",
                            Code = "SysKeyVal-6",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6347),
                            EnglishName = "Configuration",
                            Icon = "fas fa-code-branch",
                            IndonesiahName = "Konfigurasi",
                            IsActive = true,
                            IsDeleted = false,
                            ModuleId = 6L,
                            ScreenCode = "SysKeyVal"
                        },
                        new
                        {
                            Id = 7L,
                            ArabicName = "اللغات",
                            Code = "Languages-7",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6360),
                            EnglishName = "Languages",
                            Icon = "fas fa-code-branch",
                            IsActive = true,
                            IsDeleted = false,
                            ModuleId = 2L,
                            ScreenCode = "Languages"
                        },
                        new
                        {
                            Id = 8L,
                            ArabicName = "الاصناف",
                            Code = "Categories-8",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6431),
                            EnglishName = "Categories",
                            Icon = "fas fa-code-branch",
                            IsActive = true,
                            IsDeleted = false,
                            ModuleId = 2L,
                            ScreenCode = "Categories"
                        },
                        new
                        {
                            Id = 9L,
                            ArabicName = "مجموعة العمر",
                            Code = "AgeGroup-9",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6447),
                            EnglishName = "AgeGroup",
                            Icon = "fas fa-code-branch",
                            IsActive = true,
                            IsDeleted = false,
                            ModuleId = 2L,
                            ScreenCode = "AgeGroup"
                        });
                });

            modelBuilder.Entity("Model.SysKeyVal", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<long?>("CompanyId");

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsDeleted");

                    b.Property<string>("Key")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("SysKeyVal");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "SysKeyVal-1",
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 508, DateTimeKind.Local).AddTicks(6274),
                            IsActive = true,
                            IsDeleted = false,
                            Key = "Timeout",
                            Value = "10"
                        });
                });

            modelBuilder.Entity("Model.UserGroups", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<long>("GroupId");

                    b.Property<long>("UserId");

                    b.HasKey("Id");

                    b.ToTable("UserGroups");
                });

            modelBuilder.Entity("Model.Users", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Code")
                        .HasMaxLength(50);

                    b.Property<long>("CompanyId");

                    b.Property<long?>("CreatedBy");

                    b.Property<DateTime>("CreationDate");

                    b.Property<string>("Email");

                    b.Property<bool>("IsActive");

                    b.Property<bool>("IsCompanyManager");

                    b.Property<bool>("IsDeleted");

                    b.Property<bool>("IsMaster");

                    b.Property<DateTime?>("ModificationDate");

                    b.Property<long?>("ModifiedBy");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.Property<string>("Token");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(200);

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            Code = "US-1",
                            CompanyId = 0L,
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 508, DateTimeKind.Local).AddTicks(5142),
                            IsActive = true,
                            IsCompanyManager = false,
                            IsDeleted = false,
                            IsMaster = true,
                            Password = "4VCsPmt2m2ChrhC2k/i+hw==",
                            UserName = "AdminDev"
                        },
                        new
                        {
                            Id = 2L,
                            Code = "US-2",
                            CompanyId = 0L,
                            CreationDate = new DateTime(2020, 9, 27, 15, 37, 37, 508, DateTimeKind.Local).AddTicks(5900),
                            IsActive = true,
                            IsCompanyManager = false,
                            IsDeleted = false,
                            IsMaster = false,
                            Password = "iskJ2vxZtjfyhzajgb3HkQ==",
                            UserName = "Admin"
                        });
                });

            modelBuilder.Entity("Model.District", b =>
                {
                    b.HasOne("Model.City")
                        .WithMany("Districts")
                        .HasForeignKey("CityID")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
