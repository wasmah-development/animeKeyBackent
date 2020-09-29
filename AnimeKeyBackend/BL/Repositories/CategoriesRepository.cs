using BL.Infrastructure;
using Model;
using System;
using System.Linq;

namespace BL.Repositories
{
    public interface ICategoriesRepository
    { }

    public class CategoriesRepository : Repository<Category>, ICategoriesRepository
    {
        public CategoriesRepository(DBContext ctx) : base(ctx)
        { }

        public override IQueryable<Category> GetAll()
        { return base.GetAll().Where(ent =>  !ent.IsDeleted); }

    }
}
