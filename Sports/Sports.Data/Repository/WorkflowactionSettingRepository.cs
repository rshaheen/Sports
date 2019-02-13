using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sports.Data.Infrastructure;
using Sports.Model;

namespace Sports.Data.Repository
{
    public class WorkflowactionSettingRepository: RepositoryBase<WorkflowactionSetting>, IWorkflowactionSettingRepository
    {
        public WorkflowactionSettingRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface IWorkflowactionSettingRepository : IRepository<WorkflowactionSetting>
    {
    }
}
