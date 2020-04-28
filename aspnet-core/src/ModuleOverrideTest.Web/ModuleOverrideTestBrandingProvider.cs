using Volo.Abp.AspNetCore.Mvc.UI.Theme.Shared.Components;
using Volo.Abp.DependencyInjection;

namespace ModuleOverrideTest.Web
{
    [Dependency(ReplaceServices = true)]
    public class ModuleOverrideTestBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "ModuleOverrideTest";
    }
}
