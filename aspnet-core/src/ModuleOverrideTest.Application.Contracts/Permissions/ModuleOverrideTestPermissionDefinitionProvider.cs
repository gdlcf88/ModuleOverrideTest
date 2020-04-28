using ModuleOverrideTest.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace ModuleOverrideTest.Permissions
{
    public class ModuleOverrideTestPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(ModuleOverrideTestPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(ModuleOverrideTestPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<ModuleOverrideTestResource>(name);
        }
    }
}
