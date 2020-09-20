using BL.Infrastructure;
using Model;
using System.Linq;

namespace BL.Repositories
{
    public interface ICityRepository
    { }

    public class CityRepository : Repository<City>, ICityRepository
    {
        public CityRepository(DBContext ctx) : base(ctx)
        { }

        public override IQueryable<City> GetAll()
        {
            return base.GetAll().Where(ent => !ent.IsDeleted);
        }
    }
}
