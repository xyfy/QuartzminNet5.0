using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Yun.Demo.Controllers
{
    public abstract class DemoControllerBase: AbpController
    {
        protected DemoControllerBase()
        {
            LocalizationSourceName = DemoConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
