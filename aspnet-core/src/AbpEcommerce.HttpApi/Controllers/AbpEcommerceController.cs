using AbpEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpEcommerce.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpEcommerceController : AbpControllerBase
{
    protected AbpEcommerceController()
    {
        LocalizationResource = typeof(AbpEcommerceResource);
    }
}
