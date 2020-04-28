using ModuleOverrideTest.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace ModuleOverrideTest
{
    [DependsOn(
        typeof(ModuleOverrideTestEntityFrameworkCoreTestModule)
        )]
    public class ModuleOverrideTestDomainTestModule : AbpModule
    {

    }
}