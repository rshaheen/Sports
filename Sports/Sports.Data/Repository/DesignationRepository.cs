using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sports.Data.Infrastructure;
using Sports.Model;

namespace Sports.Data.Repository
{
    public class DesignationRepository: RepositoryBase<Designation>, IDesignationRepository
    {
        public DesignationRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface IDesignationRepository : IRepository<Designation>
    {
    }
}
