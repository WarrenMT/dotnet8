using Dotnet8.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace Dotnet8.Permissions;

public class Dotnet8PermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(Dotnet8Permissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(Dotnet8Permissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<Dotnet8Resource>(name);
    }
}
