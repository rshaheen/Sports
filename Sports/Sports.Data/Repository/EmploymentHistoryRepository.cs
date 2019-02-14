using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sports.Data.Infrastructure;
using Sports.Model.Models;

namespace Sports.Data.Repository
{
    public class EmploymentHistoryRepository: RepositoryBase<EmploymentHistory>, IEmploymentHistoryRepository
    {
        public EmploymentHistoryRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface IEmploymentHistoryRepository : IRepository<EmploymentHistory>
    {
    }
}
