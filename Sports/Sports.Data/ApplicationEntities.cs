using Microsoft.AspNet.Identity.EntityFramework;
using Sports.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sports.Data.Models
{
    public class ApplicationEntities : DbContext
    {
        public ApplicationEntities()
            : base("DBConnection")
        {
            /**
             * It's not necessary to remove the virtual keyword from the navigation properties (which would make lazy loading completely 
             * impossible for the model). It's enough to disable proxy creation (which disables lazy loading as well) for the specific circumstances 
             * where proxies are disturbing, like serialization
             */
            //this.Configuration.ProxyCreationEnabled = false;
        }

        public virtual DbSet<ActionLog> ActionLogs { get; set; }
        public virtual DbSet<BusinessUser> BusinessUsers { get; set; }
        public virtual DbSet<Country> Countries { get; set; }
        public virtual DbSet<Currency> Currencies { get; set; }
        public virtual DbSet<Department> Departments { get; set; }
        public virtual DbSet<Designation> Designations { get; set; }
        public virtual DbSet<Employee> Employees { get; set; }
        public virtual DbSet<EmploymentHistory> EmploymentHistories { get; set; }
        public virtual DbSet<MatchRound> MatchRounds { get; set; }
        public virtual DbSet<Module> Modules { get; set; }
        public virtual DbSet<NotificationSetting> NotificationSettings { get; set; }
        public virtual DbSet<Player> Players { get; set; }
        public virtual DbSet<PlayerType> PlayerTypes { get; set; }
        public virtual DbSet<Result> Results { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<RoleSubModuleItem> RoleSubModuleItems { get; set; }
        public virtual DbSet<SubModule> SubModules { get; set; }
        public virtual DbSet<SubModuleItem> SubModuleItems { get; set; }
        public virtual DbSet<Team> Teams { get; set; }
        public virtual DbSet<TeamPlayer> TeamPlayers { get; set; }
        public virtual DbSet<TeamRole> TeamRoles { get; set; }
        public virtual DbSet<Venue> Venues { get; set; }
        public virtual DbSet<Workflowaction> Workflowactions { get; set; }
        public virtual DbSet<WorkflowactionSetting> WorkflowactionSettings { get; set; }


        public virtual void Commit()
        {
            base.SaveChanges();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BusinessUser>()
                .HasMany(e => e.ActionLogs)
                .WithOptional(e => e.BusinessUser)
                .HasForeignKey(e => e.Who);

            modelBuilder.Entity<Department>()
                .HasMany(e => e.Designations)
                .WithRequired(e => e.Department)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.EmploymentHistories)
                .WithRequired(e => e.Employee)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Employee>()
                .HasMany(e => e.NotificationSettings)
                .WithOptional(e => e.Employee)
                .HasForeignKey(e => e.NotifiedEmployeeId);

            modelBuilder.Entity<SubModuleItem>()
                .HasMany(e => e.SubModuleItem1)
                .WithOptional(e => e.SubModuleItem2)
                .HasForeignKey(e => e.BaseItemId);

            modelBuilder.Entity<SubModuleItem>()
                .HasMany(e => e.WorkflowactionSettings)
                .WithOptional(e => e.SubModuleItem)
                .HasForeignKey(e => e.SubMouduleItemId);
        }
    }
}
