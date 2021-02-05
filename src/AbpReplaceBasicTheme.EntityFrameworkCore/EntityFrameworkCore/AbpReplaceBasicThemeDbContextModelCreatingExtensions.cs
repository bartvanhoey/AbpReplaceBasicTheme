using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace AbpReplaceBasicTheme.EntityFrameworkCore
{
    public static class AbpReplaceBasicThemeDbContextModelCreatingExtensions
    {
        public static void ConfigureAbpReplaceBasicTheme(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AbpReplaceBasicThemeConsts.DbTablePrefix + "YourEntities", AbpReplaceBasicThemeConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}