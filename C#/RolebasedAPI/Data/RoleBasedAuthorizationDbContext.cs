using Microsoft.EntityFrameworkCore;
using RolebasedAPI.Models;

namespace RolebasedAPI.Data
{
    public class RoleBasedAuthorizationDbContext : DbContext
    {
        public RoleBasedAuthorizationDbContext(DbContextOptions<RoleBasedAuthorizationDbContext> options) : base(options) { }
        public DbSet<User> Users { get; set; }
    }
}
