using TestUpgrade.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace TestUpgrade.Permissions;

public class TestUpgradePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(TestUpgradePermissions.GroupName);

        //Define your own permissions here. Example:
        //myGroup.AddPermission(TestUpgradePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<TestUpgradeResource>(name);
    }
}
