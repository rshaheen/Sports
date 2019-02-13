using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sports.Data.Infrastructure;
using Sports.Model;

namespace Sports.Data.Repository
{
    public class ActionLogRepository: RepositoryBase<ActionLog>, IActionLogRepository
    {
        public ActionLogRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface IActionLogRepository : IRepository<ActionLog>
    {
    }
}
