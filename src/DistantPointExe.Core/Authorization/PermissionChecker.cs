using Abp.Authorization;
using DistantPointExe.Authorization.Roles;
using DistantPointExe.Authorization.Users;

namespace DistantPointExe.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
