using AbpEcommerce.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpEcommerce.DbMigrator;

[DependsOn(
    typeof(AbpAutofacModule),
    typeof(AbpEcommerceEntityFrameworkCoreModule),
    typeof(AbpEcommerceApplicationContractsModule)
    )]
public class AbpEcommerceDbMigratorModule : AbpModule
{
    public override void ConfigureServices(ServiceConfigurationContext context)
    {
        Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
    }
}
