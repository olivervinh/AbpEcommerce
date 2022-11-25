using AbpEcommerce.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpEcommerce;

[DependsOn(
    typeof(AbpEcommerceEntityFrameworkCoreTestModule)
    )]
public class AbpEcommerceDomainTestModule : AbpModule
{

}
