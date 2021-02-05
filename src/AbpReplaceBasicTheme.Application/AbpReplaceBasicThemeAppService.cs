using System;
using System.Collections.Generic;
using System.Text;
using AbpReplaceBasicTheme.Localization;
using Volo.Abp.Application.Services;

namespace AbpReplaceBasicTheme
{
    /* Inherit your application services from this class.
     */
    public abstract class AbpReplaceBasicThemeAppService : ApplicationService
    {
        protected AbpReplaceBasicThemeAppService()
        {
            LocalizationResource = typeof(AbpReplaceBasicThemeResource);
        }
    }
}
