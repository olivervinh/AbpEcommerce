using AbpEcommerce.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpEcommerce.Permissions;

public class AbpEcommercePermissionDefinitionProvider : PermissionDefinitionProvider
{
    public override void Define(IPermissionDefinitionContext context)
    {
        var myGroup = context.AddGroup(AbpEcommercePermissions.GroupName);
        //Define your own permissions here. Example:
        //myGroup.AddPermission(AbpEcommercePermissions.MyPermission1, L("Permission:MyPermission1"));
    }

    private static LocalizableString L(string name)
    {
        return LocalizableString.Create<AbpEcommerceResource>(name);
    }
}
