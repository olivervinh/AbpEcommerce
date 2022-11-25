using System.Threading.Tasks;

namespace AbpEcommerce.Data;

public interface IAbpEcommerceDbSchemaMigrator
{
    Task MigrateAsync();
}
