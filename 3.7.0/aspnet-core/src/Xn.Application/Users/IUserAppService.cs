using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Xn.Roles.Dto;
using Xn.Users.Dto;

namespace Xn.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
