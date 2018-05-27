using System.Threading.Tasks;
using Xn.Configuration.Dto;

namespace Xn.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
