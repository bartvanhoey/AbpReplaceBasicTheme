using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Modularity;

namespace AbpReplaceBasicTheme.EntityFrameworkCore
{
    [DependsOn(
        typeof(AbpReplaceBasicThemeEntityFrameworkCoreModule)
        )]
    public class AbpReplaceBasicThemeEntityFrameworkCoreDbMigrationsModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAbpDbContext<AbpReplaceBasicThemeMigrationsDbContext>();
        }
    }
}
