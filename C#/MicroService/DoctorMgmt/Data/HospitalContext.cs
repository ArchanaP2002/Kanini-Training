using Microsoft.EntityFrameworkCore;
using Models;

namespace DoctorMgmt.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<DoctorDetails> DoctorDetails { get; set; }
    }
}
