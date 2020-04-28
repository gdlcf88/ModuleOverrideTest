using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace ModuleOverrideTest.EntityFrameworkCore
{
    [DependsOn(
        typeof(ModuleOverrideTestEntityFrameworkCoreModule)
        )]
    public class ModuleOverrideTestEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<ModuleOverrideTestMigrationsDbContext>();
        }
    }
}
