using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using DzeTask.Configuration.Dto;

namespace DzeTask.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : DzeTaskAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
