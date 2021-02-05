using Volo.Abp.Bundling;

namespace AbpReplaceBasicTheme.Blazor
{
    public class AbpReplaceBasicThemeBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {
        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}