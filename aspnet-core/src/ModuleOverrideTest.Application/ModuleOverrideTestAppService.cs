using System;
using System.Collections.Generic;
using System.Text;
using ModuleOverrideTest.Localization;
using Volo.Abp.Application.Services;

namespace ModuleOverrideTest
{
    /* Inherit your application services from this class.
     */
    public abstract class ModuleOverrideTestAppService : ApplicationService
    {
        protected ModuleOverrideTestAppService()
        {
            LocalizationResource = typeof(ModuleOverrideTestResource);
        }
    }
}
