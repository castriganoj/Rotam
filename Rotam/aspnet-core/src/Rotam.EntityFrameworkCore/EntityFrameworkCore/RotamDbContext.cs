using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using Rotam.Authorization.Roles;
using Rotam.Authorization.Users;
using Rotam.MultiTenancy;

namespace Rotam.EntityFrameworkCore
{
    public class RotamDbContext : AbpZeroDbContext<Tenant, Role, User, RotamDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public RotamDbContext(DbContextOptions<RotamDbContext> options)
            : base(options)
        {
        }
    }
}
