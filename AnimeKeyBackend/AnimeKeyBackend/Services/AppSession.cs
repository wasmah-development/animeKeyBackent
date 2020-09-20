using Microsoft.AspNetCore.Http;
using Model;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AnimeKeyBackend.Services
{
    public partial class AppSession
    {
        public static string EmployeesUploads = "Uploads/Employees";
        public static string CompanyImagesUploads = "Uploads/Companies";
        public static string CustomersUploads = "Uploads/Customers";
        public static string FilesUploads = "Uploads/Files";



        public static Users CurrentUser
        {
            get
            {
                var _user = WebHelpers.HttpContext.Session.Get<Users>("CurrentUser");
                if (_user != null)
                {
                    try
                    {  return _user; }
                    catch { }
                }
                return null;
            }
            set
            {
                WebHelpers.HttpContext.Session.Set("CurrentUser", value);
            }
        }

        public static bool IsArabic { get; set; } = true;

        public static bool IsEngligh { get; set; } = false;

        public static bool IsIndonesia { get; set; } = false;
    }
}
