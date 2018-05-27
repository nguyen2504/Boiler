using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using Xn.Configuration.Dto;

namespace Xn.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : XnAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
