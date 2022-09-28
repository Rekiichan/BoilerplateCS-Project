using System.Threading.Tasks;
using MyPrjTest.Configuration.Dto;

namespace MyPrjTest.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
