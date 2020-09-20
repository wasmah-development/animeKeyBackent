using BL.Infrastructure;
using Model;
using System.Linq;

namespace BL.Repositories
{
    public interface INationalityRepository
    { }
    public class NationalityRepository : Repository<Nationality>, INationalityRepository
    {
        public NationalityRepository(DBContext ctx) : base(ctx)
        { }

        public override IQueryable<Nationality> GetAll()
        { return base.GetAll().Where(ent => !ent.IsDeleted); }
    }
}