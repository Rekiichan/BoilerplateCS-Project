using System.Threading.Tasks;
using Abp.Authorization;
using Abp.Runtime.Session;
using MyPrjTest.Configuration.Dto;

namespace MyPrjTest.Configuration
{
    [AbpAuthorize]
    public class ConfigurationAppService : MyPrjTestAppServiceBase, IConfigurationAppService
    {
        public async Task ChangeUiTheme(ChangeUiThemeInput input)
        {
            await SettingManager.ChangeSettingForUserAsync(AbpSession.ToUserIdentifier(), AppSettingNames.UiTheme, input.Theme);
        }
    }
}
