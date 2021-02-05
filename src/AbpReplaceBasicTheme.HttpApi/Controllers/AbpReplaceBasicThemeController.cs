using AbpReplaceBasicTheme.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AbpReplaceBasicTheme.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AbpReplaceBasicThemeController : AbpController
    {
        protected AbpReplaceBasicThemeController()
        {
            LocalizationResource = typeof(AbpReplaceBasicThemeResource);
        }
    }
}