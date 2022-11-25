using Volo.Abp.Modularity;

namespace AbpEcommerce;

[DependsOn(
    typeof(AbpEcommerceApplicationModule),
    typeof(AbpEcommerceDomainTestModule)
    )]
public class AbpEcommerceApplicationTestModule : AbpModule
{

}
