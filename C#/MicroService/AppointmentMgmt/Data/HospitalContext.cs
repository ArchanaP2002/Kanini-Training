using Microsoft.EntityFrameworkCore;
using Models;

namespace AppointmentMgmt.Data
{
    public class HospitalContext : DbContext
    {
        public HospitalContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
    }
}
