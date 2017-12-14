using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using DzeTask.Roles.Dto;
using DzeTask.Users.Dto;

namespace DzeTask.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UpdateUserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();
    }
}