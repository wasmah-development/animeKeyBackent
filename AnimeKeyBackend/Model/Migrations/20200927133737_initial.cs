using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Model.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeGroup",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CountryArabicName = table.Column<string>(maxLength: 500, nullable: false),
                    CountryEnglishName = table.Column<string>(maxLength: 500, nullable: false),
                    StartAge = table.Column<int>(nullable: false),
                    EndAge = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgeGroup", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ArabicName = table.Column<string>(maxLength: 500, nullable: false),
                    EnglishName = table.Column<string>(maxLength: 500, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "City",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ArabicName = table.Column<string>(maxLength: 500, nullable: false),
                    EnglishName = table.Column<string>(maxLength: 500, nullable: true),
                    IndonesiahName = table.Column<string>(maxLength: 500, nullable: true),
                    CountryID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_City", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ArabicName = table.Column<string>(maxLength: 500, nullable: false),
                    EnglishName = table.Column<string>(maxLength: 500, nullable: true),
                    IndonesiahName = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GroupPermissions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupId = table.Column<long>(nullable: false),
                    PermissionId = table.Column<long>(nullable: false),
                    ScreenId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ArabicName = table.Column<string>(maxLength: 500, nullable: false),
                    EnglishName = table.Column<string>(maxLength: 500, nullable: true),
                    IndonesiahName = table.Column<string>(maxLength: 500, nullable: true),
                    IsMaster = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Groups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LookUpItems",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArabicName = table.Column<string>(nullable: false),
                    EnglishName = table.Column<string>(nullable: true),
                    IndonesiahName = table.Column<string>(maxLength: 500, nullable: true),
                    LookUpId = table.Column<long>(nullable: false),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUpItems", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "LookUps",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ArabicName = table.Column<string>(nullable: false),
                    EnglishName = table.Column<string>(nullable: true),
                    IndonesiahName = table.Column<string>(maxLength: 500, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LookUps", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Modules",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ArabicName = table.Column<string>(maxLength: 500, nullable: false),
                    EnglishName = table.Column<string>(maxLength: 500, nullable: false),
                    IndonesiahName = table.Column<string>(maxLength: 500, nullable: true),
                    Icon = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Modules", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Permissions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ArabicName = table.Column<string>(maxLength: 500, nullable: false),
                    EnglishName = table.Column<string>(maxLength: 500, nullable: false),
                    IndonesiahName = table.Column<string>(maxLength: 500, nullable: true),
                    PermissionCode = table.Column<string>(maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Permissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ScreenPermissions",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    ScreenId = table.Column<long>(nullable: false),
                    PermissionId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScreenPermissions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Screens",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ArabicName = table.Column<string>(maxLength: 500, nullable: false),
                    EnglishName = table.Column<string>(maxLength: 500, nullable: false),
                    IndonesiahName = table.Column<string>(maxLength: 500, nullable: true),
                    ScreenCode = table.Column<string>(maxLength: 500, nullable: false),
                    Icon = table.Column<string>(nullable: false),
                    URL = table.Column<string>(nullable: true),
                    ModuleId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Screens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SysKeyVal",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Key = table.Column<string>(maxLength: 100, nullable: false),
                    Value = table.Column<string>(maxLength: 200, nullable: false),
                    CompanyId = table.Column<long>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SysKeyVal", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    GroupId = table.Column<long>(nullable: false),
                    UserId = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    UserName = table.Column<string>(maxLength: 200, nullable: false),
                    Email = table.Column<string>(nullable: true),
                    Password = table.Column<string>(maxLength: 200, nullable: false),
                    IsMaster = table.Column<bool>(nullable: false),
                    CompanyId = table.Column<long>(nullable: false),
                    IsCompanyManager = table.Column<bool>(nullable: false),
                    Token = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "District",
                columns: table => new
                {
                    Id = table.Column<long>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Code = table.Column<string>(maxLength: 50, nullable: true),
                    CreatedBy = table.Column<long>(nullable: true),
                    CreationDate = table.Column<DateTime>(nullable: false),
                    ModifiedBy = table.Column<long>(nullable: true),
                    ModificationDate = table.Column<DateTime>(nullable: true),
                    IsActive = table.Column<bool>(nullable: false),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ArabicName = table.Column<string>(maxLength: 500, nullable: false),
                    EnglishName = table.Column<string>(maxLength: 500, nullable: true),
                    IndonesiahName = table.Column<string>(maxLength: 500, nullable: true),
                    CityID = table.Column<long>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_District", x => x.Id);
                    table.ForeignKey(
                        name: "FK_District_City_CityID",
                        column: x => x.CityID,
                        principalTable: "City",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Groups",
                columns: new[] { "Id", "ArabicName", "Code", "CreatedBy", "CreationDate", "EnglishName", "IndonesiahName", "IsActive", "IsDeleted", "IsMaster", "ModificationDate", "ModifiedBy" },
                values: new object[] { 1L, "مجموعة عامة", "GR-1", null, new DateTime(2020, 9, 27, 15, 37, 37, 508, DateTimeKind.Local).AddTicks(1283), "General Group", null, true, false, true, null, null });

            migrationBuilder.InsertData(
                table: "LookUpItems",
                columns: new[] { "Id", "ArabicName", "CompanyId", "CreatedBy", "CreationDate", "EnglishName", "IndonesiahName", "IsActive", "IsDeleted", "LookUpId", "ModificationDate", "ModifiedBy" },
                values: new object[,]
                {
                    { 1L, "ذكر", null, null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(595), "Male", null, true, false, 1L, null, null },
                    { 2L, "انثي", null, null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(1108), "Female", null, true, false, 1L, null, null }
                });

            migrationBuilder.InsertData(
                table: "LookUps",
                columns: new[] { "Id", "ArabicName", "CreatedBy", "CreationDate", "EnglishName", "IndonesiahName", "IsDeleted", "ModificationDate", "ModifiedBy" },
                values: new object[] { 1L, "الجنس", null, new DateTime(2020, 9, 27, 15, 37, 37, 508, DateTimeKind.Local).AddTicks(8474), "Gender", null, false, null, null });

            migrationBuilder.InsertData(
                table: "Modules",
                columns: new[] { "Id", "ArabicName", "Code", "CreatedBy", "CreationDate", "EnglishName", "Icon", "IndonesiahName", "IsActive", "IsDeleted", "ModificationDate", "ModifiedBy" },
                values: new object[,]
                {
                    { 1L, "ادارة المستخدمين", "MOD-1", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(2374), "Users Management", "fas fa-users-cog", "Manajemen Pengguna", true, false, null, null },
                    { 2L, "اعدادات النظام", "MOD-2", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(2828), "System Settings", "fa fa-cogs", "Pengaturan sistem", true, false, null, null },
                    { 6L, "الاعدادات", "MOD-6", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(2848), "Configuration", "fa fa-cogs", "Konfigurasi", true, false, null, null }
                });

            migrationBuilder.InsertData(
                table: "Permissions",
                columns: new[] { "Id", "ArabicName", "Code", "CreatedBy", "CreationDate", "EnglishName", "IndonesiahName", "IsActive", "IsDeleted", "ModificationDate", "ModifiedBy", "PermissionCode" },
                values: new object[,]
                {
                    { 4L, "حذف", "PER-4", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(4274), "Delete", null, true, false, null, null, null },
                    { 3L, "تعديل", "PER-3", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(4260), "Edit", null, true, false, null, null, null },
                    { 2L, "أنشاء", "PER-2", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(4240), "Create", null, true, false, null, null, null },
                    { 1L, "عرض", "PER-1", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(4021), "View", null, true, false, null, null, "Index" }
                });

            migrationBuilder.InsertData(
                table: "ScreenPermissions",
                columns: new[] { "Id", "PermissionId", "ScreenId" },
                values: new object[,]
                {
                    { 24L, 4L, 6L },
                    { 33L, 1L, 7L },
                    { 34L, 2L, 7L },
                    { 35L, 3L, 7L },
                    { 36L, 4L, 7L },
                    { 37L, 1L, 8L },
                    { 43L, 3L, 9L },
                    { 39L, 3L, 8L },
                    { 40L, 4L, 8L },
                    { 41L, 1L, 9L },
                    { 42L, 2L, 9L },
                    { 23L, 3L, 6L },
                    { 44L, 4L, 9L },
                    { 38L, 2L, 8L },
                    { 22L, 2L, 6L },
                    { 21L, 1L, 6L },
                    { 3L, 3L, 1L },
                    { 1L, 1L, 1L },
                    { 2L, 2L, 1L },
                    { 16L, 4L, 4L },
                    { 5L, 1L, 2L },
                    { 6L, 2L, 2L },
                    { 7L, 3L, 2L },
                    { 8L, 4L, 2L },
                    { 4L, 4L, 1L },
                    { 10L, 2L, 3L },
                    { 11L, 3L, 3L },
                    { 12L, 4L, 3L },
                    { 13L, 1L, 4L },
                    { 14L, 2L, 4L },
                    { 15L, 3L, 4L },
                    { 9L, 1L, 3L }
                });

            migrationBuilder.InsertData(
                table: "Screens",
                columns: new[] { "Id", "ArabicName", "Code", "CreatedBy", "CreationDate", "EnglishName", "Icon", "IndonesiahName", "IsActive", "IsDeleted", "ModificationDate", "ModifiedBy", "ModuleId", "ScreenCode", "URL" },
                values: new object[,]
                {
                    { 8L, "الاصناف", "Categories-8", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6431), "Categories", "fas fa-code-branch", null, true, false, null, null, 2L, "Categories", null },
                    { 7L, "اللغات", "Languages-7", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6360), "Languages", "fas fa-code-branch", null, true, false, null, null, 2L, "Languages", null },
                    { 6L, "ترتيب", "SysKeyVal-6", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6347), "Configuration", "fas fa-code-branch", "Konfigurasi", true, false, null, null, 6L, "SysKeyVal", null },
                    { 5L, "افرع الشركة", "SC-5", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6332), "Company Branches", "fas fa-code-branch", "Cabang Perusahaan", true, false, null, null, 1L, "CompanyBranches", null },
                    { 2L, "المستخدمين", "UUS-2", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6282), "Users", "fas fa-users-cog", "Pengguna", true, false, null, null, 1L, "Users", null },
                    { 3L, "المعلومات الثابتة", "SSL-3", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6305), "LookUps", "fas fa-indent", "Lihatlah", true, false, null, null, 2L, "LookUps", null },
                    { 1L, "المجموعات", "UGR-1", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(5823), "Groups", "fas fa-users", "Grup", true, false, null, null, 1L, "Groups", null },
                    { 9L, "مجموعة العمر", "AgeGroup-9", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6447), "AgeGroup", "fas fa-code-branch", null, true, false, null, null, 2L, "AgeGroup", null },
                    { 4L, "الدول والمدن والمناطق", "CCD-4", null, new DateTime(2020, 9, 27, 15, 37, 37, 509, DateTimeKind.Local).AddTicks(6319), "Countries , Cities & Districts", "fas fa-globe-europe", "Negara, Kota, dan Distrik", true, false, null, null, 2L, "Country", null }
                });

            migrationBuilder.InsertData(
                table: "SysKeyVal",
                columns: new[] { "Id", "Code", "CompanyId", "CreatedBy", "CreationDate", "IsActive", "IsDeleted", "Key", "ModificationDate", "ModifiedBy", "Value" },
                values: new object[] { 1L, "SysKeyVal-1", null, null, new DateTime(2020, 9, 27, 15, 37, 37, 508, DateTimeKind.Local).AddTicks(6274), true, false, "Timeout", null, null, "10" });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "Code", "CompanyId", "CreatedBy", "CreationDate", "Email", "IsActive", "IsCompanyManager", "IsDeleted", "IsMaster", "ModificationDate", "ModifiedBy", "Password", "Token", "UserName" },
                values: new object[,]
                {
                    { 1L, "US-1", 0L, null, new DateTime(2020, 9, 27, 15, 37, 37, 508, DateTimeKind.Local).AddTicks(5142), null, true, false, false, true, null, null, "4VCsPmt2m2ChrhC2k/i+hw==", null, "AdminDev" },
                    { 2L, "US-2", 0L, null, new DateTime(2020, 9, 27, 15, 37, 37, 508, DateTimeKind.Local).AddTicks(5900), null, true, false, false, false, null, null, "iskJ2vxZtjfyhzajgb3HkQ==", null, "Admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_District_CityID",
                table: "District",
                column: "CityID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgeGroup");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Country");

            migrationBuilder.DropTable(
                name: "District");

            migrationBuilder.DropTable(
                name: "GroupPermissions");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "LookUpItems");

            migrationBuilder.DropTable(
                name: "LookUps");

            migrationBuilder.DropTable(
                name: "Modules");

            migrationBuilder.DropTable(
                name: "Permissions");

            migrationBuilder.DropTable(
                name: "ScreenPermissions");

            migrationBuilder.DropTable(
                name: "Screens");

            migrationBuilder.DropTable(
                name: "SysKeyVal");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "City");
        }
    }
}
