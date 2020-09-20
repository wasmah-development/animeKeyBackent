using BL.Infrastructure;
using Model;
using System.Linq;

namespace BL.Repositories
{
    public interface ICountryRepository
    { }

    public class CountryRepository : Repository<Country>, ICountryRepository
    {
        private DBContext _ctx;

        public CountryRepository(DBContext ctx) : base(ctx)
        { _ctx = ctx; }

        public override IQueryable<Country> GetAll()
        {
            return base.GetAll().Where(ent => !ent.IsDeleted);
        }

        //public  bool IsRelated(long id)
        //{
        //    var cities = _ctx.City.Where(ent => ent.CountryID == id).Select(ent=>ent.Id);
        //    var district = _ctx.District.Where(ent => cities.Contains(ent.CityID));
        //    if (companyBranch != null)
        //        return true;
        //    return false;
        //}
    }
}
