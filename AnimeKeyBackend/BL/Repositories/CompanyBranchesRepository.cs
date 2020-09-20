using BL.Infrastructure;
using Model;
using System.Linq;

namespace BL.Repositories
{
    public interface ICompanyBranchesRepository
    { }

    public class CompanyBranchesRepository : Repository<CompanyBranch>, ICompanyBranchesRepository
    {
        public CompanyBranchesRepository(DBContext ctx) : base(ctx)
        { }

        public override IQueryable<CompanyBranch> GetAll(long companyId=0)
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
