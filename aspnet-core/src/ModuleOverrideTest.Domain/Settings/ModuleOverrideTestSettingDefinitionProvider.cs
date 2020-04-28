using Volo.Abp.Settings;

namespace ModuleOverrideTest.Settings
{
    public class ModuleOverrideTestSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(ModuleOverrideTestSettings.MySetting1));
        }
    }
}
