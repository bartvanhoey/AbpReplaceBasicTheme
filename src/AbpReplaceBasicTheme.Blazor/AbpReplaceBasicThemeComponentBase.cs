using AbpReplaceBasicTheme.Localization;
using Volo.Abp.AspNetCore.Components;

namespace AbpReplaceBasicTheme.Blazor
{
    public abstract class AbpReplaceBasicThemeComponentBase : AbpComponentBase
    {
        protected AbpReplaceBasicThemeComponentBase()
        {
            LocalizationResource = typeof(AbpReplaceBasicThemeResource);
        }
    }
}
