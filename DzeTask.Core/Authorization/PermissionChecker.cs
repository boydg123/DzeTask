using Abp.Authorization;
using DzeTask.Authorization.Roles;
using DzeTask.Authorization.Users;

namespace DzeTask.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {

        }
    }
}
