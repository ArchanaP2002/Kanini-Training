using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace Authorization.Autzh
{
    public class ApplicationDBContext : IdentityDbContext<IdentityUser>

    {
        public ApplicationDBContext(DbContextOptions
            <ApplicationDBContext>options) : base (options)
        {
            
        }
        protected override void OnModelCreating(ModelBuilder Builder)
        {
            base.OnModelCreating(Builder);
        }
    }
}
