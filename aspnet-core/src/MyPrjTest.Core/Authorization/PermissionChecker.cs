using Abp.Authorization;
using MyPrjTest.Authorization.Roles;
using MyPrjTest.Authorization.Users;

namespace MyPrjTest.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
