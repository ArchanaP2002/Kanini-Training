using HotelApi.model_s;
using Microsoft.EntityFrameworkCore;

namespace HotelApi.data
{
    public class HotelContext : DbContext

    {
        public HotelContext(DbContextOptions<HotelContext> options) : base(options)
        {

        }

        
        public DbSet<Hotel> Hotels { get; set; } // represents the hotel table in the database
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Users> Users { get; set; }
        public DbSet<ServantsDetails> Servers { get; set; }

 
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=LAPTOP-PKS4NBKU\\SQLEXPRESS; database=HotelApi; integrated security=true; TrustServerCertificate=true");
        }  //Connection string 

       
    }
}
