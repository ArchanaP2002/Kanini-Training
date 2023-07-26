using Microsoft.EntityFrameworkCore;

namespace FitnessApi.model_s
{
    public class FitnessContext : DbContext
    {
        public FitnessContext(DbContextOptions<FitnessContext> options) : base(options)
        {
        }

        public DbSet<Users> Users { get; set; }
        public DbSet<Formdata> Form { get; set; }
        public DbSet<Register> Register { get; set; }
        public DbSet<Trainers> Trainers { get; set; }
        public DbSet<AdminLogin> AdminLogin { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-PKS4NBKU\\SQLEXPRESS; database=FitnessApi; integrated security=true;" +
                " TrustServerCertificate=true");
        }  //Connection string 
    }
}
