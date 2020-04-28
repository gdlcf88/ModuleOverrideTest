using ModuleOverrideTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ModuleOverrideTest.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class ModuleOverrideTestPageModel : AbpPageModel
    {
        protected ModuleOverrideTestPageModel()
        {
            LocalizationResourceType = typeof(ModuleOverrideTestResource);
        }
    }
}