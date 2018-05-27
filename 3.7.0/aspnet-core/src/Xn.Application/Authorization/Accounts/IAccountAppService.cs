using System.Threading.Tasks;
using Abp.Application.Services;
using Xn.Authorization.Accounts.Dto;

namespace Xn.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
