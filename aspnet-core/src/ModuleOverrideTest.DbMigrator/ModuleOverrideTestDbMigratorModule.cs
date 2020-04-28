using ModuleOverrideTest.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace ModuleOverrideTest.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(ModuleOverrideTestEntityFrameworkCoreDbMigrationsModule),
        typeof(ModuleOverrideTestApplicationContractsModule)
        )]
    public class ModuleOverrideTestDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
