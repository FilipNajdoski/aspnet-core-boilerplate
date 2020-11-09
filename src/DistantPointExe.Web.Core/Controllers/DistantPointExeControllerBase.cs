using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace DistantPointExe.Controllers
{
    public abstract class DistantPointExeControllerBase: AbpController
    {
        protected DistantPointExeControllerBase()
        {
            LocalizationSourceName = DistantPointExeConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
