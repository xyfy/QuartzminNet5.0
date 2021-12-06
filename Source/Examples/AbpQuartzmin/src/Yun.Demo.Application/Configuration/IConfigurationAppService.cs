using System.Threading.Tasks;
using Yun.Demo.Configuration.Dto;

namespace Yun.Demo.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
