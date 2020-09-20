using BL.Extension;
using BL.Infrastructure;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using static BL.SharedCS.Enumrations;

namespace BL.Repositories
{
    public interface ISysKeyValRepository
    { }

    public class SysKeyValRepository : Repository<SysKeyVal>, ISysKeyValRepository
    {
        private DBContext _ctx;
        public SysKeyValRepository(DBContext ctx) : base(ctx)
        { _ctx = ctx; }

        public override IQueryable<SysKeyVal> GetAll(long companyId = 0)
        {
            if (companyId != 0)
            {
                return base.GetAll().Where(ent => !ent.IsDeleted && ent.CompanyId == companyId);
            }
            else
            {
                return base.GetAll().Where(ent => !ent.IsDeleted);
            }
        }
    }
}
