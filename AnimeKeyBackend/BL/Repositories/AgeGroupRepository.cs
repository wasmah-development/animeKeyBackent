using BL.Infrastructure;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL.Repositories
{
    public interface IAgeGroupRepository
    { }
    public class AgeGroupRepository : Repository<AgeGroup>, IAgeGroupRepository
    {
        public AgeGroupRepository(DBContext ctx) : base(ctx)
        { }

        public override IQueryable<AgeGroup> GetAll()
        { return base.GetAll().Where(ent => !ent.IsDeleted); }
    }
}
