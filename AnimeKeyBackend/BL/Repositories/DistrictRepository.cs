using BL.Infrastructure;
using Model;
using System.Linq;

namespace BL.Repositories
{
    public interface IDistrictsRepository
    { }

    public class DistrictRepository : Repository<District>, IDistrictsRepository
    {
        public DistrictRepository(DBContext ctx) : base(ctx)
        { }

        public override IQueryable<District> GetAll(long companyId = 0)
        {
           
                return base.GetAll().Where(ent => !ent.IsDeleted);
        }
    }
}
