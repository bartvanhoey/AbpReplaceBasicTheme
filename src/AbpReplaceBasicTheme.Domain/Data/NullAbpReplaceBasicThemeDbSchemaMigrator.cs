using System.Threading.Tasks;
using Volo.Abp.DependencyInjection;

namespace AbpReplaceBasicTheme.Data
{
    /* This is used if database provider does't define
     * IAbpReplaceBasicThemeDbSchemaMigrator implementation.
     */
    public class NullAbpReplaceBasicThemeDbSchemaMigrator : IAbpReplaceBasicThemeDbSchemaMigrator, ITransientDependency
    {
        public Task MigrateAsync()
        {
            return Task.CompletedTask;
        }
    }
}