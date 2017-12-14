using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using DzeTask.EntityFramework;

namespace DzeTask.Migrator
{
    [DependsOn(typeof(DzeTaskDataModule))]
    public class DzeTaskMigratorModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer<DzeTaskDbContext>(null);

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}