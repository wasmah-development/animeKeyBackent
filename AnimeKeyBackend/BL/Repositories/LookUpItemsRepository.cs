using BL.Infrastructure;
using Model;
using System.Linq;

namespace BL.Repositories
{
    public interface ILookUpItemsRepository
    { }

    public class LookUpItemsRepository : Repository<LookUpItems>, ILookUpItemsRepository
    {
        public LookUpItemsRepository(DBContext ctx) : base(ctx)
        { }

        public override IQueryable<LookUpItems> GetAll()
        { return base.GetAll().Where(ent => !ent.IsDeleted); }
    }
}
