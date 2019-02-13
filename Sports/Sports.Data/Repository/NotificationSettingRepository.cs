using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Sports.Data.Infrastructure;
using Sports.Model;

namespace Sports.Data.Repository
{
    public class NotificationSettingRepository: RepositoryBase<NotificationSetting>, INotificationSettingRepository
    {
        public NotificationSettingRepository(IDatabaseFactory databaseFactory)
            : base(databaseFactory)
        {
        }
    }

    public interface INotificationSettingRepository : IRepository<NotificationSetting>
    {
    }
}
