using System;
using System.Linq;
using System.Linq.Dynamic.Core;
using Microsoft.AspNetCore.Mvc;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Authorization.Users;
using Microsoft.AspNetCore.Http;
using Xn.Authorization.Roles;
using Xn.Authorization.Users;
using Xn.Controllers;
using Xn.Services;

namespace Xn.Web.Controllers
{
    [AbpMvcAuthorize]
    public class HomeController : XnControllerBase
    {
        private readonly UserManager _userManager;
        private readonly RoleManager _roleManager;
        private readonly NhanVienService _nhanVienService;
        private readonly CompanyService _company;
        private readonly NccService _nccService;
        public HomeController(UserManager userManager, 
            NhanVienService nhanVienService,
            CompanyService company,
            NccService nccService,
            RoleManager roleManager)
        {
            _userManager = userManager;
            _nhanVienService = nhanVienService;
            _company = company;
            _nccService = nccService;
            _roleManager = roleManager;
        }


        public ActionResult Index()
        {
           
            var id = _userManager.AbpSession;
            if (id != null)
            {
                
                var user = _userManager.Users.FirstOrDefault(j => j.Id.Equals(id.UserId));
                if (user != null)
                {
                    Response.Cookies.Delete("id");
                    var lh = _userManager.Users.ToList()
                        .Find(j => j.CreatorUserId == 1 && j.EmailAddress.Equals(user.EmailAddress));
                    if (lh == null) return View();
                    var check = _company.GetByIdCty(int.Parse(lh.Id.ToString()));
                    
                    CookieOptions options = new CookieOptions();
                    options.Expires = DateTime.Now.AddDays(1);
                    Response.Cookies.Append("id", lh.Id.ToString(), options);
                    //Response.Cookies.Append("idcty", lh.Id.ToString(), options);
                    if (check == null)
                    {
                        return RedirectToAction("Create", "Company");
                    }
                    else
                    {
                        //var checkncc = _nccService.GetFist(check.Code);
                        Response.Cookies.Append("code", check.Code, options);
                    }
                }
                
            }
          
            return View();
        }
	}
}
