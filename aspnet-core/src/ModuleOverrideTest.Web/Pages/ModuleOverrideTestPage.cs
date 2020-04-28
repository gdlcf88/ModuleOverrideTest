using Microsoft.AspNetCore.Mvc.Localization;
using Microsoft.AspNetCore.Mvc.Razor.Internal;
using ModuleOverrideTest.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace ModuleOverrideTest.Web.Pages
{
    /* Inherit your UI Pages from this class. To do that, add this line to your Pages (.cshtml files under the Page folder):
     * @inherits ModuleOverrideTest.Web.Pages.ModuleOverrideTestPage
     */
    public abstract class ModuleOverrideTestPage : AbpPage
    {
        [RazorInject]
        public IHtmlLocalizer<ModuleOverrideTestResource> L { get; set; }
    }
}
