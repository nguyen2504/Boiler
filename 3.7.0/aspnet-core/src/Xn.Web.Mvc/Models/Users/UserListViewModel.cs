using System.Collections.Generic;
using Xn.Roles.Dto;
using Xn.Users.Dto;

namespace Xn.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}
