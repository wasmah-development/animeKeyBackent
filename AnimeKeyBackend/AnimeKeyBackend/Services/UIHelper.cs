using BL.Infrastructure;
using Microsoft.AspNetCore.Mvc.Rendering;
using Model;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using static BL.SharedCS.Enumrations;

namespace AnimeKeyBackend.Services
{
    public static class UIHelper
    {


       

        public static HashSet<LookUpItems> GetLookUpItems(EN_LookUps lookup, IUnitOfWork _uow)
        {
            var result = _uow.LookUpItemsRepository.GetMany(ent => ent.IsActive && !ent.IsDeleted && ent.LookUpId == (long)lookup).OrderBy(ent => ent.ArabicName).OrderBy(ent => ent.EnglishName).ToHashSet();
            return result;
        }

        public static string GeneratCode(EN_Screens screen, IUnitOfWork _uow)
        {
            var count = 0;
            string code = "";
            switch (screen)
            {
                case EN_Screens.Groups:
                    count = _uow.GroupsRepository.GetMany(ent => true).Count();
                    code = "UGR-" + (count + 1);
                    break;
                case EN_Screens.Users:
                    count = _uow.UsersRepository.GetMany(ent => true).Count();
                    code = "US-" + (count+1);
                    break;
                //case EN_Screens.Categories:
                //    count = _uow.CategoriesRepository.GetMany(ent => true).Count();
                //    code = "CAT-" + (count + 1);
                //    break;
                //case EN_Screens.AgeGroup:
                //    count = _uow.AgeGroupRepository.GetMany(ent => true).Count();
                //    code = "AgeGrp-" + (count + 1);
                //    break;
                default:
                    count = 1;
                    break;
            }
            return code;
        }
        public static string GetContentType(string path)
        {
            var types = GetMimeTypes();
            var ext = Path.GetExtension(path).ToLowerInvariant();
            return types[ext];
        }

        private static Dictionary<string, string> GetMimeTypes()
        {
            return new Dictionary<string, string>
            {
                {".txt", "text/plain"},
                {".pdf", "application/pdf"},
                {".doc", "application/vnd.ms-word"},
                {".docx", "application/vnd.ms-word"},
                {".xls", "application/vnd.ms-excel"},
                {".xlsx", "application/vnd.openxmlformats officedocument.spreadsheetml.sheet"},
                {".png", "image/png"},
                {".jpg", "image/jpeg"},
                {".jpeg", "image/jpeg"},
                {".gif", "image/gif"},
                {".csv", "text/csv"}
            };
        }
    }
}
