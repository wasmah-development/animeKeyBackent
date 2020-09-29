using Microsoft.EntityFrameworkCore;

using System;

namespace Model
{
    public class DBContext : DbContext
    {

        public DBContext(DbContextOptions<DBContext> options)
        : base(options)
        {
            ChangeTracker.LazyLoadingEnabled = false;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            #region Initial Data
            modelBuilder.Entity<Groups>().HasData(new Groups
            {
                Id = 1,
                Code = "GR-1",
                ArabicName = "مجموعة عامة",
                EnglishName = "General Group",
                CreationDate = DateTime.Now,
                IsMaster = true
            });

            modelBuilder.Entity<Users>().HasData(new Users
            {
                Id = 1,
                Code = "US-1",
                UserName = "AdminDev",
                Password = "4VCsPmt2m2ChrhC2k/i+hw==",
                CreationDate = DateTime.Now,
                IsMaster = true
            });
            modelBuilder.Entity<Users>().HasData(new Users
            {
                Id = 2,
                Code = "US-2",
                UserName = "Admin",
                Password = "iskJ2vxZtjfyhzajgb3HkQ==",
                CreationDate = DateTime.Now

            });
            #endregion

            #region Sys Key Val
            modelBuilder.Entity<SysKeyVal>().HasData(new SysKeyVal
            {
                Id = 1,
                Code = "SysKeyVal-1",
                Key = "Timeout",
                Value = "10"
            });

            #endregion

            #region Lookups
            //1- Gender
            modelBuilder.Entity<LookUps>().HasData(new LookUps
            {
                Id = 1,
                EnglishName = "Gender",
                ArabicName = "الجنس",
                CreationDate = DateTime.Now
            });

            modelBuilder.Entity<LookUpItems>().HasData(new LookUpItems
            {
                Id = 1,
                EnglishName = "Male",
                ArabicName = "ذكر",
                LookUpId = 1,
                CreationDate = DateTime.Now
            });
            modelBuilder.Entity<LookUpItems>().HasData(new LookUpItems
            {
                Id = 2,
                EnglishName = "Female",
                ArabicName = "انثي",
                LookUpId = 1,
                CreationDate = DateTime.Now
            });

          
            #endregion

            #region Modules

            modelBuilder.Entity<Modules>().HasData(new Modules
            {
                Id = 1,
                Code = "MOD-1",
                ArabicName = "ادارة المستخدمين",
                EnglishName = "Users Management",
                IndonesiahName = "Manajemen Pengguna",
                CreationDate = DateTime.Now,
                Icon = "fas fa-users-cog",
            });

            modelBuilder.Entity<Modules>().HasData(new Modules
            {
                Id = 2,
                Code = "MOD-2",
                ArabicName = "اعدادات النظام",
                EnglishName = "System Settings",
                IndonesiahName = "Pengaturan sistem",
                Icon = "fa fa-cogs",
                CreationDate = DateTime.Now
            });


            modelBuilder.Entity<Modules>().HasData(new Modules
            {
                Id = 6,
                Code = "MOD-6",
                ArabicName = "الاعدادات",
                EnglishName = "Configuration",
                IndonesiahName = "Konfigurasi",
                Icon = "fa fa-cogs",
                CreationDate = DateTime.Now
            });

            #endregion

            #region Permissions

            // View
            modelBuilder.Entity<Permissions>().HasData(new Permissions
            {
                Id = 1,
                Code = "PER-1",
                ArabicName = "عرض",
                EnglishName = "View",
                PermissionCode = "Index",
                CreationDate = DateTime.Now
            });

            // Create
            modelBuilder.Entity<Permissions>().HasData(new Permissions
            {
                Id = 2,
                Code = "PER-2",
                ArabicName = "أنشاء",
                EnglishName = "Create",
                CreationDate = DateTime.Now
            });

            // Edit
            modelBuilder.Entity<Permissions>().HasData(new Permissions
            {
                Id = 3,
                Code = "PER-3",
                ArabicName = "تعديل",
                EnglishName = "Edit",
                CreationDate = DateTime.Now
            });

            // Delete
            modelBuilder.Entity<Permissions>().HasData(new Permissions
            {
                Id = 4,
                Code = "PER-4",
                ArabicName = "حذف",
                EnglishName = "Delete",
                CreationDate = DateTime.Now
            });

            #endregion

            #region Screens
             
            // 1- groups
            modelBuilder.Entity<Screens>().HasData(new Screens
            {
                Id = 1,
                Code = "UGR-1",
                ArabicName = "المجموعات",
                EnglishName = "Groups",
                IndonesiahName = "Grup",
                ScreenCode = "Groups",
                Icon = "fas fa-users",
                CreationDate = DateTime.Now,
                ModuleId = 1
            });

            // 2- users
            modelBuilder.Entity<Screens>().HasData(new Screens
            {
                Id = 2,
                Code = "UUS-2",
                ArabicName = "المستخدمين",
                EnglishName = "Users",
                IndonesiahName = "Pengguna",
                ScreenCode = "Users",
                Icon = "fas fa-users-cog",
                CreationDate = DateTime.Now,
                ModuleId = 1
            });

            // 3- Lookups
            modelBuilder.Entity<Screens>().HasData(new Screens
            {
                Id = 3,
                Code = "SSL-3",
                ArabicName = "المعلومات الثابتة",
                EnglishName = "LookUps",
                IndonesiahName = "Lihatlah",
                ScreenCode = "LookUps",
                Icon = "fas fa-indent",
                CreationDate = DateTime.Now,
                ModuleId = 2
            });

           
            // 4- Countries
            modelBuilder.Entity<Screens>().HasData(new Screens
            {
                Id = 4,
                Code = "CCD-4",
                ArabicName = "الدول والمدن والمناطق",
                EnglishName = "Countries , Cities & Districts",
                IndonesiahName = "Negara, Kota, dan Distrik",
                ScreenCode = "Country",
                Icon = "fas fa-globe-europe",
                CreationDate = DateTime.Now,
                ModuleId = 2
            });


            // 5- Company Branch
            modelBuilder.Entity<Screens>().HasData(new Screens
            {
                Id = 5,
                Code = "SC-5",
                ArabicName = "افرع الشركة",
                EnglishName = "Company Branches",
                IndonesiahName = "Cabang Perusahaan",
                ScreenCode = "CompanyBranches",
                Icon = "fas fa-code-branch",
                CreationDate = DateTime.Now,
                ModuleId = 1
            });


            // 6- SysKeyVal 
            modelBuilder.Entity<Screens>().HasData(new Screens
            {
                Id = 6,
                Code = "SysKeyVal-6",
                ArabicName = "ترتيب",
                EnglishName = "Configuration",
                IndonesiahName = "Konfigurasi",
                ScreenCode = "SysKeyVal",
                Icon = "fas fa-code-branch",
                CreationDate = DateTime.Now,
                ModuleId = 6
            });
            
            // 7- Language
            modelBuilder.Entity<Screens>().HasData(new Screens
            {
                Id = 7,
                Code = "Languages-7",
                ArabicName = "اللغات",
                EnglishName = "Languages",
                ScreenCode = "Languages",
                Icon = "fas fa-code-branch",
                CreationDate = DateTime.Now,
                ModuleId = 2
            });
            // 8- Categories
            modelBuilder.Entity<Screens>().HasData(new Screens
            {
                Id = 8,
                Code = "Categories-8",
                ArabicName = "الاصناف",
                EnglishName = "Categories",
                ScreenCode = "Categories",
                Icon = "fas fa-code-branch",
                CreationDate = DateTime.Now,
                ModuleId = 2
            });
            // 9- AgeGroup
            modelBuilder.Entity<Screens>().HasData(new Screens
            {
                Id = 9,
                Code = "AgeGroup-9",
                ArabicName = "مجموعة العمر",
                EnglishName = "AgeGroup",
                ScreenCode = "AgeGroup",
                Icon = "fas fa-code-branch",
                CreationDate = DateTime.Now,
                ModuleId = 2
            });




            #endregion

            #region Screens Permissions

            // groups
            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 1,
                ScreenId = 1,
                PermissionId = 1
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 2,
                ScreenId = 1,
                PermissionId = 2
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 3,
                ScreenId = 1,
                PermissionId = 3
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 4,
                ScreenId = 1,
                PermissionId = 4
            });

            // Users
            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 5,
                ScreenId = 2,
                PermissionId = 1
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 6,
                ScreenId = 2,
                PermissionId = 2
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 7,
                ScreenId = 2,
                PermissionId = 3
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 8,
                ScreenId = 2,
                PermissionId = 4
            });

            // Lookups
            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 9,
                ScreenId = 3,
                PermissionId = 1
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 10,
                ScreenId = 3,
                PermissionId = 2
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 11,
                ScreenId = 3,
                PermissionId = 3
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 12,
                ScreenId = 3,
                PermissionId = 4
            });

            // JobTitle
            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 13,
                ScreenId = 4,
                PermissionId = 1
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 14,
                ScreenId = 4,
                PermissionId = 2
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 15,
                ScreenId = 4,
                PermissionId = 3
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 16,
                ScreenId = 4,
                PermissionId = 4
            });

            // TaskType
            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 21,
                ScreenId = 6,
                PermissionId = 1
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 22,
                ScreenId = 6,
                PermissionId = 2
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 23,
                ScreenId = 6,
                PermissionId = 3
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 24,
                ScreenId = 6,
                PermissionId = 4
            });

            // Countries
            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 33,
                ScreenId = 7,
                PermissionId = 1
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 34,
                ScreenId = 7,
                PermissionId = 2
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 35,
                ScreenId = 7,
                PermissionId = 3
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 36,
                ScreenId = 7,
                PermissionId = 4
            });

            // Categories
            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 37,
                ScreenId = 8,
                PermissionId = 1
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 38,
                ScreenId = 8,
                PermissionId = 2
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 39,
                ScreenId = 8,
                PermissionId = 3
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 40,
                ScreenId = 8,
                PermissionId = 4
            });
            // 9- AgeGroup
            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 41,
                ScreenId = 9,
                PermissionId = 1
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 42,
                ScreenId = 9,
                PermissionId = 2
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 43,
                ScreenId = 9,
                PermissionId = 3
            });

            modelBuilder.Entity<ScreenPermissions>().HasData(new ScreenPermissions
            {
                Id = 44,
                ScreenId = 9,
                PermissionId = 4
            });

            #endregion

            base.OnModelCreating(modelBuilder);
        }

        public virtual DbSet<LookUps> LookUps { get; set; }
        public virtual DbSet<LookUpItems> LookUpItems { get; set; }
        public virtual DbSet<Country> Country { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<District> District { get; set; }
        public virtual DbSet<GroupPermissions> GroupPermissions { get; set; }
        public virtual DbSet<Groups> Groups { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<Permissions> Permissions { get; set; }
        public virtual DbSet<ScreenPermissions> ScreenPermissions { get; set; }
        public virtual DbSet<Screens> Screens { get; set; }
        public virtual DbSet<UserGroups> UserGroups { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<SysKeyVal> SysKeyVal { get; set; }
        //public virtual DbSet<Category> Categories { get; set; }
        //public virtual DbSet<AgeGroup> AgeGroup { get; set; }
    }
}
