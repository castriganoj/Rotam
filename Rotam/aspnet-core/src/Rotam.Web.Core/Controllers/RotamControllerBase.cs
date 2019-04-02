using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Rotam.Controllers
{
    public abstract class RotamControllerBase: AbpController
    {
        protected RotamControllerBase()
        {
            LocalizationSourceName = RotamConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
