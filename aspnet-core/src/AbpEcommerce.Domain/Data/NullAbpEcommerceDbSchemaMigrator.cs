using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpEcommerce.Data;

/* This is used if database provider does't define
 * IAbpEcommerceDbSchemaMigrator implementation.
 */
public class NullAbpEcommerceDbSchemaMigrator : IAbpEcommerceDbSchemaMigrator, ITransientDependency
{
    public Task MigrateAsync()
    {
        return Task.CompletedTask;
    }
}
