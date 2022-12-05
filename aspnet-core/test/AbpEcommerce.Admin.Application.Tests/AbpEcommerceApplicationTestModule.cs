using Volo.Abp.Modularity;

namespace AbpEcommerce.Admin;

[DependsOn(
    typeof(AbpEcommerceAdminApplicationModule),
    typeof(AbpEcommerceDomainTestModule)
    )]
public class AbpEcommerceApplicationTestModule : AbpModule
{

}
