using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace ModuleOverrideTest.HttpApi.Client.ConsoleTestApp
{
    [DependsOn(
        typeof(ModuleOverrideTestHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class ModuleOverrideTestConsoleApiClientModule : AbpModule
    {
        
    }
}
