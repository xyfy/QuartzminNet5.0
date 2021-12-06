using Abp.Application.Services;
using Yun.Demo.MultiTenancy.Dto;

namespace Yun.Demo.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

