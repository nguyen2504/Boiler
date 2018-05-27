using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Xn.Controllers;

namespace Xn.Web.Controllers
{
    [AbpMvcAuthorize]
    public class AboutController : XnControllerBase
    {
        public ActionResult Index()
        {
            return View();
        }
	}
}
