using ModuleOverrideTest.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace ModuleOverrideTest.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class ModuleOverrideTestController : AbpController
    {
        protected ModuleOverrideTestController()
        {
            LocalizationResource = typeof(ModuleOverrideTestResource);
        }
    }
}