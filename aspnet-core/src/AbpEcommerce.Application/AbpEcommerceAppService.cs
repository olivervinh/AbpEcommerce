using System;
using System.Collections.Generic;
using System.Text;
using AbpEcommerce.Localization;
using Volo.Abp.Application.Services;

namespace AbpEcommerce;

/* Inherit your application services from this class.
 */
public abstract class AbpEcommerceAppService : ApplicationService
{
    protected AbpEcommerceAppService()
    {
        LocalizationResource = typeof(AbpEcommerceResource);
    }
}
