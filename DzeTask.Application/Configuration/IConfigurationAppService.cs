using System.Threading.Tasks;
using Abp.Application.Services;
using DzeTask.Configuration.Dto;

namespace DzeTask.Configuration
{
    public interface IConfigurationAppService: IApplicationService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}