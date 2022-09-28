using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using MyPrjTest.Authorization.Roles;
using MyPrjTest.Authorization.Users;
using MyPrjTest.MultiTenancy;

namespace MyPrjTest.EntityFrameworkCore
{
    public class MyPrjTestDbContext : AbpZeroDbContext<Tenant, Role, User, MyPrjTestDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public MyPrjTestDbContext(DbContextOptions<MyPrjTestDbContext> options)
            : base(options)
        {
        }
    }
}
