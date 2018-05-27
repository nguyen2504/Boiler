using Microsoft.AspNetCore.Mvc;
using Xn.Controllers;

namespace Xn.Web.Controllers
{
    public class AngularController : XnControllerBase
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}