using AbpEcommerce.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpEcommerce.Admin.Controllers;

/* Inherit your controllers from this class.
 */
public abstract class AbpEcommerceAdminController : AbpControllerBase
{
    protected AbpEcommerceAdminController()
    {
        LocalizationResource = typeof(AbpEcommerceResource);
    }
}
