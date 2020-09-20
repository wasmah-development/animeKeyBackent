using BL.Infrastructure;
using Model;
using System.Linq;

namespace BL.Repositories
{
    public interface ILookUpsRepository
    { }

    public class LookUpsRepository : Repository<LookUps>, ILookUpsRepository
    {
        public LookUpsRepository(DBContext ctx) : base(ctx)
        { }

        public override IQueryable<LookUps> GetAll()
        { return base.GetAll().Where(ent => !ent.IsDeleted); }
    }
}
