using BL.Infrastructure;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.Repositories
{
    public interface ILanguagesRepository
    { }
    public class LanguagesRepository : Repository<Languages>, ILanguagesRepository
    {
        public LanguagesRepository(DBContext ctx) : base(ctx)
        { }

        public override IQueryable<Languages> GetAll()
        {
            return base.GetAll().Where(ent => !ent.IsDeleted);
        }
    }
}
