using System.Threading.Tasks;
using Abp.Application.Services;
using Yun.Demo.Sessions.Dto;

namespace Yun.Demo.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
