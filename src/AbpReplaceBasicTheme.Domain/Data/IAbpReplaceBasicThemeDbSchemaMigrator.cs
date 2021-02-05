using System.Threading.Tasks;

namespace AbpReplaceBasicTheme.Data
{
    public interface IAbpReplaceBasicThemeDbSchemaMigrator
    {
        Task MigrateAsync();
    }
}
