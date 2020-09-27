using BL.Repositories;
using Model;
using System;

namespace BL.Infrastructure
{
    public interface IUnitOfWork : IDisposable
    {
        CompanyBranchesRepository CompanyBranchesRepository { get; }
      
        NationalityRepository NationalityRepository { get; }
        CountryRepository CountryRepository { get; }
        CityRepository CityRepository { get; }
        DistrictRepository DistrictRepository { get; }
   
        LookUpItemsRepository LookUpItemsRepository { get; }
        LookUpsRepository LookUpsRepository { get; }
        UserGroupsRepository UserGroupsRepository { get; }
        GroupPermissionsRepository GroupPermissionsRepository { get; }
        GroupsRepository GroupsRepository { get; }
   
        ScreenPermissionsRepository ScreenPermissionsRepository { get; }
        PermissionsRepository PermissionsRepository { get; }
        ScreensRepository ScreensRepository { get; }
        ModulesRepository ModulesRepository { get; }
        UsersRepository UsersRepository { get; }
       
        SysKeyValRepository SysKeyValRepository { get; }
    
        LanguagesRepository LanguagesRepository { get; }
        //CategoriesRepository CategoriesRepository { get; }

        //AgeGroupRepository AgeGroupRepository { get; }


        void ExecuteSqlCommand(string sqlCommand);
        int Save();

    }
}
