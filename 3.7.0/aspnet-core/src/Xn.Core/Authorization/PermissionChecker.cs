using Abp.Authorization;
using Xn.Authorization.Roles;
using Xn.Authorization.Users;

namespace Xn.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
