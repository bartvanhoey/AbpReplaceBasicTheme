using System;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using AbpReplaceBasicTheme.Data;
using Volo.Abp.DependencyInjection;

namespace AbpReplaceBasicTheme.EntityFrameworkCore
{
    public class EntityFrameworkCoreAbpReplaceBasicThemeDbSchemaMigrator
        : IAbpReplaceBasicThemeDbSchemaMigrator, ITransientDependency
    {
        private readonly IServiceProvider _serviceProvider;

        public EntityFrameworkCoreAbpReplaceBasicThemeDbSchemaMigrator(
            IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public async Task MigrateAsync()
        {
            /* We intentionally resolving the AbpReplaceBasicThemeMigrationsDbContext
             * from IServiceProvider (instead of directly injecting it)
             * to properly get the connection string of the current tenant in the
             * current scope.
             */

            await _serviceProvider
                .GetRequiredService<AbpReplaceBasicThemeMigrationsDbContext>()
                .Database
                .MigrateAsync();
        }
    }
}