using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Yun.Demo.Authorization.Roles;
using Yun.Demo.Authorization.Users;
using Yun.Demo.MultiTenancy;

namespace Yun.Demo.EntityFrameworkCore
{
    public class DemoDbContext : AbpZeroDbContext<Tenant, Role, User, DemoDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public DemoDbContext(DbContextOptions<DemoDbContext> options)
            : base(options)
        {
        }
    }
}
