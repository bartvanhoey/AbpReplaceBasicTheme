using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace AbpReplaceBasicTheme
{
    [Dependency(ReplaceServices = true)]
    public class AbpReplaceBasicThemeBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AbpReplaceBasicTheme";
    }
}
