using System.Threading.Tasks;
using Abp.Application.Services;
using Xn.Sessions.Dto;

namespace Xn.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
