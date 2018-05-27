using Abp.AspNetCore.Mvc.ViewComponents;

namespace Xn.Web.Views
{
    public abstract class XnViewComponent : AbpViewComponent
    {
        protected XnViewComponent()
        {
            LocalizationSourceName = XnConsts.LocalizationSourceName;
        }
    }
}
