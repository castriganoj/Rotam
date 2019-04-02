using Abp.Authorization;
using Rotam.Authorization.Roles;
using Rotam.Authorization.Users;

namespace Rotam.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
