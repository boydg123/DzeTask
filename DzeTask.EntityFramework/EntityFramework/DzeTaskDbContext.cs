using System.Data.Common;
using System.Data.Entity;
using Abp.Zero.EntityFramework;
using DzeTask.Authorization.Roles;
using DzeTask.Authorization.Users;
using DzeTask.MultiTenancy;
using DzeTask.Tasks;

namespace DzeTask.EntityFramework
{
    public class DzeTaskDbContext : AbpZeroDbContext<Tenant, Role, User>
    {
        //TODO: Define an IDbSet for your Entities...
        public IDbSet<Task> Tasks { get; set; }

        /* NOTE: 
         *   Setting "Default" to base class helps us when working migration commands on Package Manager Console.
         *   But it may cause problems when working Migrate.exe of EF. If you will apply migrations on command line, do not
         *   pass connection string name to base classes. ABP works either way.
         */
        public DzeTaskDbContext()
            : base("Default")
        {

        }

        /* NOTE:
         *   This constructor is used by ABP to pass connection string defined in DzeTaskDataModule.PreInitialize.
         *   Notice that, actually you will not directly create an instance of DzeTaskDbContext since ABP automatically handles it.
         */
        public DzeTaskDbContext(string nameOrConnectionString)
            : base(nameOrConnectionString)
        {

        }

        //This constructor is used in tests
        public DzeTaskDbContext(DbConnection existingConnection)
         : base(existingConnection, false)
        {

        }

        public DzeTaskDbContext(DbConnection existingConnection, bool contextOwnsConnection)
         : base(existingConnection, contextOwnsConnection)
        {

        }
    }
}
