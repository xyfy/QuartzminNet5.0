using System.Threading.Tasks;
using Abp.Application.Services;
using Yun.Demo.Authorization.Accounts.Dto;

namespace Yun.Demo.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
