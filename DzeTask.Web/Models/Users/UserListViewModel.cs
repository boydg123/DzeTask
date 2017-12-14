using System.Collections.Generic;
using DzeTask.Roles.Dto;
using DzeTask.Users.Dto;

namespace DzeTask.Web.Models.Users
{
    public class UserListViewModel
    {
        public IReadOnlyList<UserDto> Users { get; set; }

        public IReadOnlyList<RoleDto> Roles { get; set; }
    }
}