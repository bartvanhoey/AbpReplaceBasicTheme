using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpReplaceBasicTheme.Blazor
{
    [Dependency(ReplaceServices = true)]
    public class AbpReplaceBasicThemeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpReplaceBasicTheme";
    }
}
