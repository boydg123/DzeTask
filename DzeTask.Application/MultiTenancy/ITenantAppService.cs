using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DzeTask.MultiTenancy.Dto;

namespace DzeTask.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
