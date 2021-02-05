using Volo.Abp.Modularity;

namespace AbpReplaceBasicTheme
{
    [DependsOn(
        typeof(AbpReplaceBasicThemeApplicationModule),
        typeof(AbpReplaceBasicThemeDomainTestModule)
        )]
    public class AbpReplaceBasicThemeApplicationTestModule : AbpModule
    {

    }
}