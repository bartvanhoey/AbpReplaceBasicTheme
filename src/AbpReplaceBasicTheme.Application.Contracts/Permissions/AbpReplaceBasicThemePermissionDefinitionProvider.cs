﻿using AbpReplaceBasicTheme.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AbpReplaceBasicTheme.Permissions
{
    public class AbpReplaceBasicThemePermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AbpReplaceBasicThemePermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AbpReplaceBasicThemePermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AbpReplaceBasicThemeResource>(name);
        }
    }
}
