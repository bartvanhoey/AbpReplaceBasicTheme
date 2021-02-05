using AbpReplaceBasicTheme.EntityFrameworkCore;
using Volo.Abp.Modularity;

namespace AbpReplaceBasicTheme
{
    [DependsOn(
        typeof(AbpReplaceBasicThemeEntityFrameworkCoreTestModule)
        )]
    public class AbpReplaceBasicThemeDomainTestModule : AbpModule
    {

    }
}