using Abp.AspNetCore.Mvc.Controllers;
using Abp.IdentityFramework;
using Microsoft.AspNetCore.Identity;

namespace Xn.Controllers
{
    public abstract class XnControllerBase: AbpController
    {
        protected XnControllerBase()
        {
            LocalizationSourceName = XnConsts.LocalizationSourceName;
        }

        protected void CheckErrors(IdentityResult identityResult)
        {
            identityResult.CheckErrors(LocalizationManager);
        }
    }
}
