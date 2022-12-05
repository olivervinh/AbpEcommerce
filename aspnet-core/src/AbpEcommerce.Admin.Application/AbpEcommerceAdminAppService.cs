using System;
using System.Collections.Generic;
using System.Text;
using AbpEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace AbpEcommerce.Admin;

/* Inherit your application services from this class.
 */
public abstract class AbpEcommerceAdminAppService : ApplicationService
{
    protected AbpEcommerceAdminAppService()
    {
        LocalizationResource = typeof(AbpEcommerceResource);
    }
}
