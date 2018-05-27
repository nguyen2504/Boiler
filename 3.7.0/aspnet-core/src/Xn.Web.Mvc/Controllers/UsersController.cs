using System.Linq;
using System.Linq.Dynamic.Core;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Abp.Application.Services.Dto;
using Abp.AspNetCore.Mvc.Authorization;
using Abp.Collections.Extensions;
using Xn.Authorization;
using Xn.Authorization.Users;
using Xn.Controllers;
using Xn.Users;
using Xn.Web.Models.Users;

namespace Xn.Web.Controllers
{
    [AbpMvcAuthorize(PermissionNames.Pages_Users)]
    public class UsersController : XnControllerBase
    {
        private readonly IUserAppService _userAppService;
        private readonly UserManager _userManager;
        public UsersController(IUserAppService userAppService, UserManager userManager)
        {
            _userAppService = userAppService;
            _userManager = userManager;
        }

        public async Task<ActionResult> Index()
        {
            var id = _userManager.AbpSession.UserId;
            var user = _userManager.Users.SingleOrDefault(j => j.Id.Equals(id));
            
            var model = new UserListViewModel();
            if (user!=null)
            {
                var users = (await _userAppService.GetAll(new PagedResultRequestDto { MaxResultCount = int.MaxValue })).
                    Items.Where(j => j.CreatorUserId == id || j.EmailAddress == user.EmailAddress).ToList(); ; // Paging not implemented yet
             
                var roles = (await _userAppService.GetRoles()).Items;
                model = new UserListViewModel
                {
                    Users = users,
                    Roles = roles
                };
            }
            ViewBag.user = user;
            
            return View(model);
        }

        public async Task<ActionResult> EditUserModal(long userId)
        {
            var user = await _userAppService.Get(new EntityDto<long>(userId));
            var roles = (await _userAppService.GetRoles()).Items;
            var model = new EditUserModalViewModel
            {
                User = user,
                Roles = roles
            };
            return View("_EditUserModal", model);
        }
    }
}
