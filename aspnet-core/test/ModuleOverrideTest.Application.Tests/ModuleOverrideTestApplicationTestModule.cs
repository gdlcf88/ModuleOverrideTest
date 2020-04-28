using Volo.Abp.Modularity;

namespace ModuleOverrideTest
{
    [DependsOn(
        typeof(ModuleOverrideTestApplicationModule),
        typeof(ModuleOverrideTestDomainTestModule)
        )]
    public class ModuleOverrideTestApplicationTestModule : AbpModule
    {

    }
}