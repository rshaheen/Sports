using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sports.Data.Infrastructure;
using Sports.Model;

namespace Sports.Data.Repository
{
    public class SubModuleItemRepository: RepositoryBase<SubModuleItem>, ISubModuleItemRepository
    {
        public SubModuleItemRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface ISubModuleItemRepository : IRepository<SubModuleItem>
    {
    }
}
