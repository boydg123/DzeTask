using System.Data.Entity;
using System.Reflection;
using Abp.Modules;
using Abp.Zero.EntityFramework;
using DzeTask.EntityFramework;

namespace DzeTask
{
    [DependsOn(typeof(AbpZeroEntityFrameworkModule), typeof(DzeTaskCoreModule))]
    public class DzeTaskDataModule : AbpModule
    {
        public override void PreInitialize()
        {
            Database.SetInitializer(new CreateDatabaseIfNotExists<DzeTaskDbContext>());

            Configuration.DefaultNameOrConnectionString = "Default";
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(Assembly.GetExecutingAssembly());
        }
    }
}
