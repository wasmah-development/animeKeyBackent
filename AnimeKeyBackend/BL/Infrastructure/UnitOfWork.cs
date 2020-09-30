using BL.Repositories;
using Microsoft.EntityFrameworkCore;
using Model;

namespace BL.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DBContext _ctx;

        public CompanyBranchesRepository CompanyBranchesRepository => new CompanyBranchesRepository(_ctx);
      
        public NationalityRepository NationalityRepository => new NationalityRepository(_ctx);
        public CountryRepository CountryRepository => new CountryRepository(_ctx);
        public CityRepository CityRepository => new CityRepository(_ctx);
        public DistrictRepository DistrictRepository => new DistrictRepository(_ctx);
      
        public LookUpItemsRepository LookUpItemsRepository => new LookUpItemsRepository(_ctx);
        public LookUpsRepository LookUpsRepository => new LookUpsRepository(_ctx);
        public UserGroupsRepository UserGroupsRepository => new UserGroupsRepository(_ctx);
        public GroupPermissionsRepository GroupPermissionsRepository => new GroupPermissionsRepository(_ctx);
        public GroupsRepository GroupsRepository => new GroupsRepository(_ctx);
      
        public ScreenPermissionsRepository ScreenPermissionsRepository => new ScreenPermissionsRepository(_ctx);
        public PermissionsRepository PermissionsRepository => new PermissionsRepository(_ctx);
        public ScreensRepository ScreensRepository => new ScreensRepository(_ctx);
        public ModulesRepository ModulesRepository => new ModulesRepository(_ctx);
        public UsersRepository UsersRepository => new UsersRepository(_ctx);
        public SysKeyValRepository SysKeyValRepository => new SysKeyValRepository(_ctx);
        public LanguagesRepository LanguagesRepository => new LanguagesRepository(_ctx);
        public CategoriesRepository CategoriesRepository => new CategoriesRepository(_ctx);
        public AgeGroupRepository AgeGroupRepository => new AgeGroupRepository(_ctx);
        public NewsRepository NewsRepository => new NewsRepository(_ctx);

        public UnitOfWork(DBContext ctx)
        {
            _ctx = ctx;
            _ctx.ChangeTracker.LazyLoadingEnabled = false;
 
        }
        public void Dispose()
        {
            _ctx.Dispose();
        }

        public void ExecuteSqlCommand(string sqlCommand)
        {
            _ctx.Database.ExecuteSqlCommand(sqlCommand);
        }

        public int Save()
        {
            return _ctx.SaveChanges();
        }
    }
}
