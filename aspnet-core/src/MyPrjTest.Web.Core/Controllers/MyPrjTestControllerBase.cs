using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace MyPrjTest.Controllers
{
    public abstract class MyPrjTestControllerBase: AbpController
    {
        protected MyPrjTestControllerBase()
        {
            LocalizationSourceName = MyPrjTestConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
