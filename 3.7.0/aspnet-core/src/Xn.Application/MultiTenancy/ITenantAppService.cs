using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Xn.MultiTenancy.Dto;

namespace Xn.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
