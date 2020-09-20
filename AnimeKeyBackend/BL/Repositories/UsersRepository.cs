using BL.Infrastructure;
using Model;
using System.Linq;

namespace BL.Repositories
{
    public interface IUsersRepository
    {  }

    public class UsersRepository :  Repository<Users>, IUsersRepository
    {
        public UsersRepository(DBContext ctx) : base(ctx)
        {  }

        public override IQueryable<Users> GetAll()
        {  return base.GetAll().Where(ent=>!ent.IsDeleted); }
    }
}
