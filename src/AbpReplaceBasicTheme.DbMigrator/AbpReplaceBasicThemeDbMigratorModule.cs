using AbpReplaceBasicTheme.EntityFrameworkCore;
using Volo.Abp.Autofac;
using Volo.Abp.BackgroundJobs;
using Volo.Abp.Modularity;

namespace AbpReplaceBasicTheme.DbMigrator
{
    [DependsOn(
        typeof(AbpAutofacModule),
        typeof(AbpReplaceBasicThemeEntityFrameworkCoreDbMigrationsModule),
        typeof(AbpReplaceBasicThemeApplicationContractsModule)
        )]
    public class AbpReplaceBasicThemeDbMigratorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpBackgroundJobOptions>(options => options.IsJobExecutionEnabled = false);
        }
    }
}
