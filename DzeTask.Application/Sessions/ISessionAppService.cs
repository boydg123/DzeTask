using System.Threading.Tasks;
using Abp.Application.Services;
using DzeTask.Sessions.Dto;

namespace DzeTask.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
