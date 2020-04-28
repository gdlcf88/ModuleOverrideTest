using EasyAbp.SharedResources;
using Volo.Abp.Account;
using Volo.Abp.FeatureManagement;
using Volo.Abp.Identity;
using Volo.Abp.Modularity;
using Volo.Abp.PermissionManagement.HttpApi;
using Volo.Abp.TenantManagement;

namespace ModuleOverrideTest
{
    [DependsOn(
        typeof(ModuleOverrideTestApplicationContractsModule),
        typeof(AbpAccountHttpApiModule),
        typeof(AbpIdentityHttpApiModule),
        typeof(AbpPermissionManagementHttpApiModule),
        typeof(AbpTenantManagementHttpApiModule),
        typeof(AbpFeatureManagementHttpApiModule),
        typeof(SharedResourcesHttpApiModule)
        )]
    public class ModuleOverrideTestHttpApiModule : AbpModule
    {
        
    }
}
