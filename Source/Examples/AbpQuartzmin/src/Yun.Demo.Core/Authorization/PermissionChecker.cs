using Abp.Authorization;
using Yun.Demo.Authorization.Roles;
using Yun.Demo.Authorization.Users;

namespace Yun.Demo.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
