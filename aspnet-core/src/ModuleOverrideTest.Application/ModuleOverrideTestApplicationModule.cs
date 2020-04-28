using EasyAbp.SharedResources;
using Volo.Abp.Account;
using Volo.Abp.AutoMapper;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement;
using Volo.Abp.TenantManagement;

namespace ModuleOverrideTest
{
    [DependsOn(
        typeof(ModuleOverrideTestDomainModule),
        typeof(AbpAccountApplicationModule),
        typeof(ModuleOverrideTestApplicationContractsModule),
        typeof(AbpIdentityApplicationModule),
        typeof(AbpPermissionManagementApplicationModule),
        typeof(AbpTenantManagementApplicationModule),
        typeof(AbpFeatureManagementApplicationModule),
        typeof(SharedResourcesApplicationModule)
        )]
    public class ModuleOverrideTestApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<ModuleOverrideTestApplicationModule>();
            });
        }
    }
}
