using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sports.Data.Infrastructure;
using Sports.Model;

namespace Sports.Data.Repository
{
    public class SubModuleRepository: RepositoryBase<SubModule>, ISubModuleRepository
    {
        public SubModuleRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface ISubModuleRepository : IRepository<SubModule>
    {
    }
}
