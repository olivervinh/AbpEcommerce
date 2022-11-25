using Volo.Abp.Settings;

namespace AbpEcommerce.Settings;

public class AbpEcommerceSettingDefinitionProvider : SettingDefinitionProvider
{
    public override void Define(ISettingDefinitionContext context)
    {
        //Define your own settings here. Example:
        //context.Add(new SettingDefinition(AbpEcommerceSettings.MySetting1));
    }
}
