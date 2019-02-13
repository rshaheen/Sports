using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sports.Data.Infrastructure;
using Sports.Model;

namespace Sports.Data.Repository
{
    public class RoleSubModuleItemRepository: RepositoryBase<RoleSubModuleItem>, IRoleSubModuleItemRepository
    {
        public RoleSubModuleItemRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface IRoleSubModuleItemRepository : IRepository<RoleSubModuleItem>
    {
    }
}
