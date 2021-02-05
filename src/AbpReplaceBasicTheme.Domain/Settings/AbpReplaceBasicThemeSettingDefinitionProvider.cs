using Volo.Abp.Settings;

namespace AbpReplaceBasicTheme.Settings
{
    public class AbpReplaceBasicThemeSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AbpReplaceBasicThemeSettings.MySetting1));
        }
    }
}
